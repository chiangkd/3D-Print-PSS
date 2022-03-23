
from ast import arg
import numpy as np
import sys
from model import *
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
                         xl=np.array([2000,100,300,0.08]),  # lower bound
                         xu=np.array([8000,200,1500,0.12])) # upper bound
    def _evaluate(self,x, out, mode, *args, **kwargs):
        f1 = -np.float64(args[mode].predict(np.array(x.append(200)).reshape(1, -1)))   #mu
        f2 = np.float64(args[mode].predict(np.array(x.append(200)).reshape(1, -1)))  #Pcv

        out["F"] = [f1, f2]


# input data = 
# ['C:\\Users\\User\\Desktop\\feature_app\\parameter_sug_max_mu_min_pcv.py', '1', '-u']

mode = input_data[1]
print(model_mu_xgb_50)   
problem = max_mu_min_pcv(mode=mode,args=[model_mu_xgb_50,
                                           model_mu_xgb_200,
                                           model_mu_xgb_400,
                                           model_mu_xgb_800])


print("in")    

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

## give parameter to model and caculate the output


## Multi-Criteria Decision Making

fl = F.min(axis=0)
fu = F.max(axis=0)
approx_ideal = F.min(axis=0)
approx_nadir = F.max(axis=0)

### parameter suggestion from NSGA-II


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

###characteristic prediction from NSGA-II###
# print(-F[i][0].round(decimals = 2), F[i][1].round(decimals = 2))    ## characteristic
##########################



data_for_pred = [np.int16(X[2][0]),                ## ox
                 np.int16(X[2][1]),                ## power
                 np.int16(X[2][2]),                ## speed
                 X[2][3].round(decimals=2)]        ## spacing




pred_mu_50 = model_mu_xgb_50(data_for_pred)
pred_Pcv_50 = model_Pcv_xgb_50(data_for_pred)
print(pred_mu_50)
print(pred_Pcv_50)

pred_mu_200 = model_mu_xgb_200(data_for_pred)
pred_Pcv_200 = model_Pcv_xgb_200(data_for_pred)
print(pred_mu_200)
print(pred_Pcv_200)

pred_mu_400 = model_mu_xgb_400(F)
pred_Pcv_400 = model_Pcv_xgb_400(F)
print(pred_mu_400)
print(pred_Pcv_400)

pred_mu_800 = model_mu_xgb_800(F)
pred_Pcv_800 = model_Pcv_xgb_800(F)
print(pred_mu_800)
print(pred_Pcv_800)


########manufacturing parameter suggestion################
print(np.int16(X[2][0]),                ## ox            #
      np.int16(X[2][1]),                ## power         #
      np.int16(X[2][2]),                ## speed         #
      X[2][3].round(decimals=2),        ## spacing       #
      np.int16(X[2][4]))                ## frequency     #
##########################################################
