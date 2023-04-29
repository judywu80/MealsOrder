# MealsOrder
Checkboxes in winform <br>
簡易點餐系統 作品說明
1. Form基本架構：
A. 以CheckBox 作餐點選項；TextBox作該選項之數量輸入，初使預設為0。
B. 另以GroupBox作外帶/內用選項，當點選內用時增加CheckBox選項，顯示內用人數。

2. 現行功能：
A. 「取消」Button，作CheckBox、TextBox初始化。
B. 「FormLoad」事件(Event)檔：
a. panel1.Color 設定藍色rgb(150,200,255);，可自行更改。
b. label8.Text 顯示 「歡迎光臨！」，當結帳完成應作顯示金額用。
c. 將上圖圓角矩形圈選處作Visible=False (不顯示)，當使用者點選「內用」時才顯示，供使用者輸入人數，。
![image](https://user-images.githubusercontent.com/122083665/235289784-6691becf-dd7c-4f7d-9724-a9957216c94a.png)

3. 作品特色：（藉由「結帳」鍵或其他事件、方法，增加下列功能）<br>
A. 基礎級：
a. 當使用者勾選「內用」應出現checkBox7、textBoxt7、label9，如勾選。「外用」應隱藏checkBox7、textBoxt7、label7(可於RadioButton_CheckedChanged處理)。

&emsp;&emsp;b. 使用者可以不勾選CheckBox，逕行於TextBox輸入數量，CheckBox應該要自動被勾選，反之TextBox稍後因錯改回0時，CheckBox也應改成未勾選；學員可利用各TextBox的TextChanged事件，讓(如checkBox1. Checked=true;)。

&emsp;&emsp;c. 當使用者勾選各CheckBox，以及於TextBox 輸入數字後，按下「結帳」鍵後，應完成計算各選項單價*數量(應逐一判斷CheckBox的Ckecked是否為true，並累計於金額變數，最後顯示於label8.Text。
![image](https://user-images.githubusercontent.com/122083665/235289843-72c0d07d-5d11-4c83-886c-0298c7b81906.png)

B. 實用級：
a. 一般級之B項功能，使用到6-7個TextChanged事件，在實例上經常是數十個，程式會很複雜，請改共用事件處理或使用其他單一事件完成本功能。

&emsp;&emsp;b. 一般級之B項功能中，使用者輸入非數字或負數，應該要有check功能，並使TextBox的Text回復"0"，CheckBox的Checked也要回復false。
※基礎級、實用級採Ckecked為true才結算。

C. 進階級：
a. 一般級之C項功能，使用到6-7個If CheckBox.checked=true; {…}，實例會更多，請考慮改以迴圈以及使用數個陣列取得「商品名稱」、「單價」、「數量」，來達成「結帳」功能。

&emsp;&emsp;b. 「結帳」時，同時將商品清單顯示在listBox1上，並試著將各行對齊，商品也應該有序號，若使用者選checkBox1、2、3、6、7五項，但序號仍然是1、2、3、4、5項；如下圖：

&emsp;&emsp;c. 如果Text.Box已輸入過數量，當該項的CheckBox被取消勾選(checked=false)，則應該讓TextBox回復"0"。

&emsp;&emsp;d. 如果CheckBox被勾選(ckecked=true)，而TextBox.Text="0";，則改成TEdit.Text="1";，即預設值為"1"。

&emsp;&emsp;e. 當使用者滑鼠點選進入某個TextBox時，應將其作內容SelectAll，方便使用者不需刪除原有數值，可直接輸入新數值。

※基礎級、實用級採Ckecked為true才計價，進階功能不會有TextBox有數量，而CheckBox沒有勾選的情況。
