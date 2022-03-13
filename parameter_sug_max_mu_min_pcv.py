import numpy as np
import sys
from model import model_mu_cat,model_mu_xgb,model_mu_lgb,model_Pcv_lgb,model_Pcv_cat,model_Pcv_xgb,model_tensile_cat,model_tensile_xgb
from pymoo.core.problem import ElementwiseProblem
from pymoo.factory import get_problem, get_sampling, get_crossover, get_mutation
from pymoo.algorithms.moo.nsga2 import NSGA2
from pymoo.factory import get_termination
from pymoo.optimize import minimize
from pymoo.decomposition.asf import ASF

## NSGA II implementation

## Using XGBoost

## define problem

input_data = [sys for sys in sys.argv];

class max_mu_min_pcv(ElementwiseProblem):    # max mu and min Pcv
    def __init__(self):
        super().__init__(n_var=5,
                         n_obj=2,
                         n_constr=0,
                         xl=np.array([2000,100,300,0.08,50]),  # lower bound
                         xu=np.array([8000,200,1500,0.12,800])) # upper bound
    def _evaluate(self, x, out, *args, **kwargs):
        f1 = -np.float64(model_mu_xgb.predict(np.array(x).reshape(1, -1)))   #mu
        f2 = np.float64(model_Pcv_xgb.predict(np.array(x).reshape(1, -1)))  #Pcv

        out["F"] = [f1, f2]

problem = max_mu_min_pcv()

    

## Initialize an Algorithm

algorithm = NSGA2(
    pop_size=40,
    n_offsprings=10,
    sampling=get_sampling("real_random"),
    crossover=get_crossover("real_sbx", prob=0.9, eta=15),
    mutation=get_mutation("real_pm", eta=20),
    eliminate_duplicates=True
)


## Define a Termination Criterion
termination = get_termination("n_gen", 40)

res = minimize(problem,
              algorithm,
              termination,
              display= None,
              seed=1,
              save_history=True,
              verbose=False)    #verbose -> dont show any thing
F = res.F
X = res.X

## Multi-Criteria Decision Making

fl = F.min(axis=0)
fu = F.max(axis=0)
approx_ideal = F.min(axis=0)
approx_nadir = F.max(axis=0)

###
## Normalizing the obtained objective values regarding the boundary
## points is relatively simple by:

nF = (F - approx_ideal) / (approx_nadir - approx_ideal)
# nF shape = (40, 2)

fl = nF.min(axis=0) 
fu = nF.max(axis=0)

## Compromise Programming

##  Here for a bi-objective problem, let us assume the 
# first objective is less a bit less important than the 
# second objective by setting the weights to

weights = np.array([0.2, 0.8])

## the decomposition method called Augmented Scalarization Function (ASF)

decomp = ASF()

i = decomp.do(nF, 1/weights).argmin()   ## BEST index
print(-F[i][0].round(decimals = 2), F[i][1].round(decimals = 2))    ## characteristic

print(np.int16(X[2][0]), np.int16(X[2][1]),     ## parameter suggestion
      np.int16(X[2][2]),
      X[2][3].round(decimals=2), 
      np.int16(X[2][4]))