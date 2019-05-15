﻿# Изпит

**Задача 8****. Групова фаза**

Груповата фаза на световното е на път да завърши и Пепи иска да разбере дали любимият му отбор ще се класира. Знае се, че важат следните правила – ако отборът е вкарал **повече голове в дадена среща** , отколкото е получил, то той **побеждава** и **получава 3 точки** , ако **броят на вкараните и получените голове е**** равен **,** получава 1 точка **, при** загуба **броят на точките** не се променя **. Окончателно отборът** се класира **, ако** общият брой **на** вкараните голове **от всички изиграни срещи** е по-голям или равен **на** броя на получените **. Напишете** програма **, която изчислява** дали отборът се е класирал.**

**Вход**

От конзолата се четат **два реда** :

- Име на отбор – **текст** ;
- Изиграни мачове  – **цяло положително число в интервала [1 … 10]**;

За **всеки изигран мач** се четат **нови два реда** :

- Вкарани голове  – **цяло положително число в интервала [1 … 10000]**;
- Получени голове  – **цяло положително число в интервала [1 … 10000]**;

**Изход**

На конзолата се отпечатват два реда:

- Ако отборът **се е**  **класирал:**

        **&quot;{името на отбора}**  **has finished the group phase with**** {брой точки} ****points****. ****&quot;**

**        &quot;**** Goal difference ****:**  **{голова разлика}.&quot;**

- Ако отборът **не се е**  **класирал:**

        **&quot;{името на отбора}**** has been eliminated from the group phase ****.****&quot;**

**      &quot;**** Goal difference ****:**  **{голова разлика}.&quot;**

**Примерен вход и изход**

| **Вход** | **Изход** | **Обяснения** |
| --- | --- | --- |
| Brazil3420011 | Brazil has finished the group phase with 5 points.Goal difference: 2. | Бразилия изиграва **три** мача: **Първи** :  вкарани голове - **4** , получени - **2** =\&gt; головата разлика е **2** =\&gt; мачът е спечелен и Бразилия получава **3** точки **Втори** :  вкарани голове - **0** , получени - **0** =\&gt; головата разлика е **0** =\&gt; мачът е завършил с равен резултат и Бразилия получава **1** точка **Трети** :  вкарани голове - **1** , получени - **1** =\&gt; головата разлика е **0** =\&gt; мачът е завършил с равен резултат и Бразилия получава **1** точка **Обща голова разлика: 2 + 0 + 0 = 2**** Общ брой точки: 3 + 1 + 1 = 5** |
| Germany20213 | Germany has been eliminated from the group phase.Goal difference: -4. | Германия изиграва **два** мача: **Първи** :  вкарани голове - **0** , получени - **2** =\&gt; головата разлика е **0 - 2 = -2** =\&gt; мачът е загубен точките все още са **0**** Втори **:  вкарани голове -** 1 **, получени -** 3 **=\&gt; головата разлика е** 1 – 3 = -2 **=\&gt; мачът е загубен точките все още са** 0****Обща голова разлика: -2 + (-2) = -4****Общ брой точки: 0 + 0 = 0** |
| Croatia432112021 | Croatia has finished the group phase with 10 points.Goal difference: 4. |   |