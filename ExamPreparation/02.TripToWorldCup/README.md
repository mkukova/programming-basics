﻿# 17.Изпит 

# 18.Задача 2. Екскурзия до световното

Пепи и неговите **петима** приятели са запалени футболни фенове и, разбира се, тази година няма да пропуснат световното първенство. За целта те трябва да закупят предварително **самолетни билети за отиване и за връщане** , както и билети за **мачовете, които ще посетят**. Тъй като закупуването на **самолетните билети** става онлайн, те получават **отстъпка от общата им сума.**

Напишете **програма** , която **изчислява общата сума** , която трябва да заплатят, както и **сумата, която трябва да**  **   **** заплати всеки един ****от приятелите**.

### Вход

От конзолата се четат **поредица от числа, всяко на отделен ред** :

- На **първия ред** – **цената на билета за отиване** – **реално число в интервала** **[****50.00...1000.00****]**
- На **втория ред** – **цената на билета за връщане** – **реално число в интервала** **[****50.00...1000.00****]**
- На **третия ред** – **цената на билета за един мач** – **реално число в интервала** **[****50.00...500.00****]**
- На **четвъртия ред** – **броят на мачовете** – **цяло число в интервала** **[****1...10****]**
- На **петия ред** – **процентната отстъпка** – **цяло число в интервала** **[****1…100****]**

### Изход

Да се отпечатат на конзолата **2 реда** :

- **Първи** ред – **цялата сума,** която трябва да заплатят, форматирана по следния начин:

&quot; **Total sum: {**** цялата сума ****} lv.****&quot;**

- **Втори** ред – **сумата за всеки един,** форматирана по следния начин:

&quot; **Each friend has to pay**  **{**** сумата за всеки един ****} lv.**&quot;

**Резултатът да е форматиран до втория знак след десетичната запетая.**

### Примерен вход и изход

| **Вход** | **Изход** | **Обяснения** |
| --- | --- | --- |
| 175280125515 | Total sum: 6070.50 lv.Each friend has to pay 1011.75 lv. | 6 \* (175 + 280) = 2730 - сумата на самолетните билети за шестимата приятели.2730 - 15% = 2320.5 - самолетните билети **след отстъпката.** 6 \* 5 \* 125 = 3750 - **общата сума на билетите за мачовете** 2320.5 + 3750 = 6070.5 - общата сума, **която трябва да заплатят.** 6070.5 / 6 = 1011.75 - сумата **за всеки един** от приятелите. |
| 210235150612 | Total sum: 7749.60 lv.Each friend has to pay 1291.60 lv. |   |
| 218.55185.90170.50417 | Total sum: 6106.16 lv.Each friend has to pay 1017.69 lv. |   |