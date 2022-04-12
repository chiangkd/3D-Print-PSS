# @file    model_old_old.py
# @author  Kuan-Di Jiang
# @brief   abandom file

from pickle import NONE
import xgboost as xgb
import numpy as np
import lightgbm as lgb
import catboost as cat
import os
import sys



current_path = os.getcwd();
folder = 'model_set';

# print(current_path + '\\' + folder)

allFileList = os.listdir(current_path + '\\' + folder); # all file array

# print(allFileList);


#input_data = [2.0000e+03, 2.0000e+02, 1.5000e+03, 1.2000e-01, 2.0000e+02]
###
## model declaration
model_mu_xgb = xgb.XGBRegressor();
model_Pcv_xgb = xgb.XGBRegressor();
model_tensile_xgb = xgb.XGBRegressor();
model_mu_cat = cat.CatBoostRegressor();
model_Pcv_cat = cat.CatBoostRegressor();
model_tensile_cat = cat.CatBoostRegressor();

## model loading
try:    # model_mu_xgb
    model_mu_xgb.load_model(current_path + '\\' + folder + '\\' + 'model_mu_xgb.json')
except:
    print("Something wrong in loading XGBoost mu model");
try:    # model_Pcv_xgb
    model_Pcv_xgb.load_model(current_path + '\\' + folder + '\\' + 'model_Pcv_xgb.json')
except:
    print("Something wrong in loading XGBoost Pcv model");
try:    # model_mu_cat
    model_mu_cat.load_model(current_path + '\\' + folder + '\\' + 'model_mu_cat.json', format='json')
except:
    print("Something wrong in loading Catboost mu model");
try:    # model_Pcv_cat
    model_Pcv_cat.load_model(current_path + '\\' + folder + '\\' + 'model_Pcv_cat.json', format='json')
except:
    print("Something wrong in loading Catboost Pcv model");
try:    # model_mu_lgb
    model_mu_lgb = lgb.Booster(model_file=current_path + '\\' + folder + '\\' + 'model_mu_lgb.json')
except:
    print("Something wrong in loading LightGBM mu model");
try:    # model_Pcv_lgb
    model_Pcv_lgb = lgb.Booster(model_file=current_path + '\\' + folder + '\\' + 'model_Pcv_lgb.json')
except:
    print("Something wrong in loading LightGBM Pcv model");
###
try:    # model_tensile_xgb
    model_tensile_xgb.load_model(current_path + '\\' + folder + '\\' + 'model_tensile_xgb.json')
except:
    print("Something wrong in loading XGBoost tensile model");
try:    # model_tensile_cat
    model_tensile_cat.load_model(current_path + '\\' + folder + '\\' + 'model_tensile_cat.json', format='json')
except:
    print("Something wrong in loading Catboost mu model");

if __name__ == '__main__':
    #print(sys.argv[1]); # sys.argv start with index = 1
    input_data = [sys for sys in sys.argv];
    input_data.pop(0);    # remove first
    input_data.pop();       # remove last
    input_data = [np.float64(data) for data in input_data]
    # input_data = [2.0000e+03, 2.0000e+02, 1.5000e+03, 1.2000e-01, 2.0000e+02]

    
    # print("input = ", input_data);
    ## make prediction
    xgb_mu_pred = np.float64(
                model_mu_xgb.predict(np.array(input_data)
                .reshape(1,-1)))
    print(xgb_mu_pred)

    cat_mu_pred = model_mu_cat.predict(input_data)
    print(cat_mu_pred)

    lgb_mu_pred = np.float64(model_mu_lgb.predict(np.array(input_data).reshape(1,-1)))
    print(lgb_mu_pred)

    xgb_Pcv_pred = np.float64(
                model_Pcv_xgb.predict(np.array(input_data)
                .reshape(1,-1)))
    print(xgb_Pcv_pred)

    cat_Pcv_pred = model_Pcv_cat.predict(input_data)
    print(cat_Pcv_pred)

    lgb_Pcv_pred = np.float64(model_Pcv_lgb.predict(np.array(input_data).reshape(1,-1)))
    print(lgb_Pcv_pred)

    input_data_for_mech = input_data;
    input_data_for_mech.pop()
    xgb_tensile_pred = np.float64(
                model_tensile_xgb.predict(np.array(input_data_for_mech)
                .reshape(1,-1)))
    print(xgb_tensile_pred)

    cat_tensile_pred = model_tensile_cat.predict(input_data_for_mech)
    print(cat_tensile_pred)

    #print("Run Successfully");


