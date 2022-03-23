import xgboost as xgb
import numpy as np
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
model_mu_xgb_50 = xgb.XGBRegressor();
model_mu_xgb_200 = xgb.XGBRegressor();
model_mu_xgb_400 = xgb.XGBRegressor();
model_mu_xgb_800 = xgb.XGBRegressor();
model_Pcv_xgb_50 = xgb.XGBRegressor();
model_Pcv_xgb_200 = xgb.XGBRegressor();
model_Pcv_xgb_400 = xgb.XGBRegressor();
model_Pcv_xgb_800 = xgb.XGBRegressor();
model_tensile_xgb = xgb.XGBRegressor();

## model loading
try:    # model_mu_xgb
    model_mu_xgb_50.load_model(current_path + '\\' + folder + '\\' + 'model_mu_xgb_50.json')
except:
    print("Something wrong in loading XGBoost mu_50 model");
try:    # model_mu_xgb
    model_mu_xgb_200.load_model(current_path + '\\' + folder + '\\' + 'model_mu_xgb_200.json')
except:
    print("Something wrong in loading XGBoost mu_200 model");
try:    # model_mu_xgb
    model_mu_xgb_400.load_model(current_path + '\\' + folder + '\\' + 'model_mu_xgb_400.json')
except:
    print("Something wrong in loading XGBoost mu_400 model");
try:    # model_mu_xgb
    model_mu_xgb_800.load_model(current_path + '\\' + folder + '\\' + 'model_mu_xgb_800.json')
except:
    print("Something wrong in loading XGBoost mu_800 model");
###Pcv###
try:    # model_Pcv_xgb
    model_Pcv_xgb_50.load_model(current_path + '\\' + folder + '\\' + 'model_Pcv_xgb_50.json')
except:
    print("Something wrong in loading XGBoost Pcv_50 model");
try:    # model_Pcv_xgb
    model_Pcv_xgb_200.load_model(current_path + '\\' + folder + '\\' + 'model_Pcv_xgb_200.json')
except:
    print("Something wrong in loading XGBoost Pcv_200 model");
try:    # model_Pcv_xgb
    model_Pcv_xgb_400.load_model(current_path + '\\' + folder + '\\' + 'model_Pcv_xgb_400.json')
except:
    print("Something wrong in loading XGBoost Pcv_400 model");
try:    # model_Pcv_xgb
    model_Pcv_xgb_800.load_model(current_path + '\\' + folder + '\\' + 'model_Pcv_xgb_800.json')
except:
    print("Something wrong in loading XGBoost Pcv_800 model");
####tensile###
try:    # model_tensile_xgb
    model_tensile_xgb.load_model(current_path + '\\' + folder + '\\' + 'model_tensile_xgb.json')
except:
    print("Something wrong in loading XGBoost tensile model");

if __name__ == '__main__':
    #print(sys.argv[1]); # sys.argv start with index = 1
    input_data = [sys for sys in sys.argv];
    input_data.pop(0);    # remove first
    input_data.pop();       # remove last
    input_data = [np.float64(data) for data in input_data]
    # input_data = [2.0000e+03, 2.0000e+02, 1.5000e+03, 1.2000e-01, 2.0000e+02]

    
    # print("input = ", input_data);
    ## make prediction

    '''

    xgb_mu_pred_50 = np.float64(
                model_mu_xgb_50.predict(np.array(input_data)
                .reshape(1,-1)))
    print(xgb_mu_pred_50)

    

    xgb_Pcv_pred = np.float64(
                model_Pcv_xgb.predict(np.array(input_data)
                .reshape(1,-1)))
    print(xgb_Pcv_pred)



    input_data_for_mech = input_data;
    input_data_for_mech.pop()
    xgb_tensile_pred = np.float64(
                model_tensile_xgb.predict(np.array(input_data_for_mech)
                .reshape(1,-1)))
    print(xgb_tensile_pred)

    '''
    #print("Run Successfully");


