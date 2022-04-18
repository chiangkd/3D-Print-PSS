# 3D Print Parameter Suggestion System

- **3D-Print-PSS** (abbrebviation) 
- [Github](https://github.com/chiangkd/3D-Print-PSS)

**xgboost version should be `1.5.1`**

## Reference

- [pymoo: Multi-objective Optimization in Python](https://arxiv.org/pdf/2002.04504.pdf)
- [A two-slope achievement scalarizing function for interactive
multiobjective optimization](https://reader.elsevier.com/reader/sd/pii/S0305054811002899?token=8A33558147B512B6A7B6304A5CCAF8C5CCD94AC8AD171B11D41CE7D14C52AB5B88387492247E8873F142527002B97679&originRegion=us-east-1&originCreation=20220408083528)
- [pymoo getting started](https://pymoo.org/getting_started/part_3.html)

## 動機
隨著科技的演進，精密複雜的零件需求與日俱增，舉凡像是航太、生醫、電機產業，在應用方面需要具有複雜立體結構的元件，而這類元件在傳統製造上難以製成，因此越來越多學者開始研究3D列印方面，而軟磁材料的應用更是因金屬3D列印的發展而有了更多元的發展。

在磁性元件中我們所關注的兩大特性為磁導率以及鐵損，在不同的應用情境下需要具有不同特性的元件，若使用金屬3D列印印製，則需要耗費大量的時間，因此在印製之前若能根據使用者所需的磁導率以及鐵損值進行參數建議，則可以避免不必要的印製過程，節省使用者的時間且避免材料浪費。

在人工智慧以及機器學習中，使用者使用訓練後的模型或是過往高效率的演算法，進行迴歸分析、分類問題以及物件偵測等等，而本文著重於將輸出的目標值，反向進行排序，從而建議使用者該如何設定輸入，以金屬3D列印作為舉例，透過使用者所希望的磁導率以及鐵損，由此基因排序演算法建議使用者該如何設定氧濃度、雷射功率、雷射速度、線間距，以此避免金屬3D列印不必要的印製浪費。


## 簡介
本系統以非凌越排序基因演算法(NSGA-II)應用於金屬3D列印的智慧化參數建議系統，首先以相對簡單且可視覺化的二維目標進行演算法的講解，在推廣至多目標的金屬3D列印參數建議，此參數建議系統可以依據使用者所需的產品特性告訴使用者該如何設定製造參數，並以此來減少不必要印製造成的時間以及耗材浪費，本文以軟磁材料作為舉例，由使用者設定所需的磁特性，經過演算法計算出製程所使用的四個參數，氧濃度、雷射功率、雷射速度、線間距。

### 程式運作流程

![](https://i.imgur.com/ey8s0wD.png)


先透過 Python 建構並訓練模型，將訓練好的模型儲存成 `JSON` 檔案提供給與 C# 交互通訊的 Python 讀檔使用
![](https://i.imgur.com/pVDTZSw.png)


## 視窗

![](https://i.imgur.com/ZWJwMIL.png)

![](https://i.imgur.com/pcTWGdi.png)


## C# 與 Python 之間的通訊

核心函數

```csharp=
 public void RunPythonScript(string sArgName, string args = "", params string[] teps)
        {
            count = 0; // initialize
            Process p = new Process();
            string path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + sArgName;// 獲得python檔案的絕對路徑（將檔案放在c#的debug資料夾中可以這樣操作）
            path = @"C:\Users\chiangkd\Desktop\Parameter-Suggestion-System\" + sArgName;//(因為我沒放debug下，所以直接寫的絕對路徑,替換掉上面的路徑了)
            p.StartInfo.FileName = @"python.exe";//沒有配環境變數的話，可以像我這樣寫python.exe的絕對路徑。如果配了，直接寫"python.exe"即可
            string sArguments = path;
            foreach (string sigstr in teps)
            {
                sArguments += " " + sigstr;//傳遞引數
            }

            sArguments += " " + args;

            p.StartInfo.Arguments = sArguments;

            p.StartInfo.UseShellExecute = false;

            p.StartInfo.RedirectStandardOutput = true;

            p.StartInfo.RedirectStandardInput = true;

            p.StartInfo.RedirectStandardError = true;

            p.StartInfo.CreateNoWindow = true;

            p.Start();
            p.BeginOutputReadLine();
            p.OutputDataReceived += new DataReceivedEventHandler(p_OutputDataReceived);
            
            Console.ReadLine();
            p.WaitForExit();
        }
```

先宣告一個 `Process` 類變數

其中
- `StartInfo` 獲取或設置要傳遞給 `Process` 的 `Start` 方法的屬性
    - `Arguments` open 程式的命令列引數
    - `UseShellExecute` 取得或設定，是否要使用作業系統 Shell 來啟動 `process`
        - 如果在啟動處理序時使用 `Shell`，則為 `true`，如果處理序應直接從可執行檔建立，則為 `false`。 預設值是 `true`
    - `RedirectStandard` 、 `RedirectStandardInput` 、 `RedirectStandardError`
        - 取得或設定，輸入輸出錯誤是否應該要從資料流讀取/寫入
    - `CreateNoWindow` 如果應該啟動處理序而不建立要包含處理序的新視窗，則為 `true`，否則為 `false`。 預設為 `false`。

## 機器學習

本程式已測試過多種模型來比較輸出，包含
- 類神經網路 DNN
- K-鄰近演算法 KNN
- 支援向量機 SVM
- 組合式學習 XGBoost 、 Catboost 、 LightGBM

綜合精確度以及效率來看組合式學習的表現最為出色，而其中又以 XGBoost 最為出眾，故在使用者介面中進行的參數建議是由 XGBoost 進行運算。

## 非凌越基因排序法 NSGA-II

**==圖源來自==**
[Nondominated Sorting Genetic Algorithm II (NSGA-II)](https://github.com/wurmen/Genetic-Algorithm-for-Job-Shop-Scheduling-and-NSGA-II/blob/master/introduction/NSGA-II/NSGA-II.md)

### 摘要

非凌越排序基因演算法(NSGA-II)引入凌越的機制以及擁擠距離的計算將基因演算法推廣至多目標的情境且有更高效的運算，透過排序的方式得出多目標的最佳解，本文講解非凌越排序基因演算法的完整計算以及選擇過程，搭配簡單的二維目標排序進行實例講解。

### NSGA-II 簡介

非凌越排序基因演算法為一種高效能的演算法用以求解多目標的問題，基於基因演算法(Genetic Algorithm, GA)的延伸，推廣至多目標的問題並在NSGA下引入菁英策略，誕生更有效的演算法NSGA-II。

**(一) 凌越(dominated)的概念**

在NSGA以及NSGA-II中核心的概念即為凌越，在單目標問題中，想要找出最佳解很容易，只需要透過簡單的數學模型進行收斂即可，但是在多目標問題時，常常有一好沒兩好，不見得多個目標都會是各自的最佳解，因此在多個目標之間如何進行取捨就是此演算法的目的。
凌越就像是位階的排序在擁有多的特徵的個體中進行優劣的排序，以一個簡單的舉例作為說明，若判斷一個人的優劣是藉由身高以及薪水做為評判標準，此時身高以及薪水就是我們的多個目標，此時若有四個人的目標分布如圖1所示。

**圖1**
![](https://i.imgur.com/849Xmlw.png)

此時由圖1可知A明顯相較於B、C、D明顯較為優秀，此時A稱為**非凌越解(non-dominated solution)**，而在B和C之間，身高和薪水各有優勢，此時難以分出高下則**互不凌越**，D不管在薪水還是在身高方面都劣於其他人。



**(二) 柏拉圖最佳解(Pareto-optimal solution)**

找到一組解，此組解彼此互不凌越，且不被此組中的任何解給凌越，則此組解稱為**柏拉圖最佳解(Pareto-optimal solution)**，這組解在二維座標平面上可以繪製成圖，形成一個前緣稱為**柏拉圖前緣(Pareto-optimal front)**，如圖2所示。

**圖2**
![](https://i.imgur.com/V7uqufm.png)

**(三)排序(Ranking)**

在經過排序獲得柏拉圖前緣之後可以得到如圖3的排序，A為非凌越解，明顯優於其他，故排序為第一，B以及C尚未分出高下但是明顯看出劣於A且優於D，故共同為列第二名，而D明顯劣於其他三者，故列為第三名。

**圖3**
![](https://i.imgur.com/Js5lcly.png)


**(四)擁擠距離(Crowding-distance)**

擁擠距離的計算如圖4所示，計算方法為根據每個解位於柏拉圖前緣上，找出該解距離最近兩個相鄰的解，來計算這兩個解的平均距離，以圖3的雙目標作為舉例，即為解以及最近相鄰的兩個解所圍成的長方形的平均邊長。

**圖4**
![](https://i.imgur.com/h5mQdu8.png)

在計算好擁擠距離之後，即可對在相同柏拉圖前緣上的解進行排序，在進行排序時，會傾向將擁擠距離較大的解進行優先排序，因為擁擠距離越大，表示該解相對於其他解的差異性越大，如此一來有助於基因演算法進行排序，可以有效防止掉入局部解。

![](https://i.imgur.com/YdKRW2x.png)

式(1)為擁擠距離的計算方法[2]，若為多目標的排序，則須再把個目標之擁擠距離加總。

![](https://i.imgur.com/uiU1tmD.png)

如此一來即可得到每個解的總擁擠距離 。


**(四)完整選擇機制**
經過上述(一)至(四)的步驟，最終每個目標值皆會有兩個屬性:
- 非凌越層級(nondomination rank)/柏拉圖前緣階級(Pareto-optimal front rank)
- 擁擠距離(crowding distance)
依據以下規則進行挑選即可獲得多目標的最佳解:
1. 先比較非凌越層級，**層級越高(Rank數字越小)優先被排序**
2. 若非凌越層級相同，**優先挑選具有擁擠距離大的優先被排序**


### 結論

透過非凌越排序基因演算法，可以有一整到完整的選擇機制進行高效率的雙目標以及多目標排序，與機器學習模型搭配可以達成:
1.	以機器學習輸入多個特徵收斂至目標值
2.	以非凌越排序基因演算法根據目標值反向推估輸入特徵

完整搭配流程如圖5所示，可以進行反向的特徵預估。

**圖5**

![](https://i.imgur.com/cMb4M2h.png)
