﻿# 1.Изпит

# 2.Задача 6. Футболни сувенири

На почивката между полувремената на мача Пепи решил да си закупи сувенир за спомен от световното. На щанд пред стадиона се предлагали различни стоки, като цените им **зависели от отбора на дадената страна**. Напишете програма, която **изчислява сумата за закупените сувенири**.

**Отборите и цените на стоките са както следва:**

|   | **Аржентина** | **Бразилия** | **Хърватия** | **Дания** |
| --- | --- | --- | --- | --- |
| **флагчета** | **3,25 лв.** | **4,20 лв.** | **2,75 лв.** | **3,10 лв.** |
| **шапки** | **7,20 лв.** | **8,50 лв.** | **6,90 лв.** | **6,50 лв.** |
| **плакати** | **5,10 лв.** | **5,35 лв.** | **4,95 лв.** | **4,80 лв.** |
| **стикери** | **1,25 лв.** | **1,20 лв.** | **1,10 лв.** | **0,90 лв.** |

### Вход

От конзолата се четат **3**  **реда** :

- **Първият ред**  **–**  **отбор** – **текст с възможности:**  **&quot;**** Argentina ****&quot;**** , &quot; ****Brazil****&quot;, &quot; ****Croatia****&quot;, &quot; ****Denmark****&quot;**
- **Вторият ред**** – ****вид сувенири**** – ****текст**** с възможности ****:****&quot; ****flags****&quot; ****, &quot;**** caps ****&quot;,**  **&quot;**** posters ****&quot;**** , &quot; ****stickers****&quot;**
- **Третият**** ред ****–**** брой закупени сувенири – цяло число в интервала **** [1…200]**

### Изход

Да се **отпечата**** на конзолата един ред** :

- **Ако страната и стоката са правилно зададени:**

          **&#39;&#39;**** Pepi bought **** { ****брой сувенири**** } { ****вид сувенири**** } **** of **** { ****отбор**** } **** for **** { ****крайна сума**** } ****lv.****&#39;&#39;**

- Ако страната не е правилно зададена:

    &quot;Invalidcountry!&quot;

- **Ако  стоката не е правилно зададена** :

    &quot;Invalid stock!&quot;

**Резултатът да е форматиран до втората цифра след десетичната запетая.**

### Примерен вход и изход

| **Вход** | **Изход** | **Обяснения** |
| --- | --- | --- |
| Brazilstickers5 | Pepi bought 5 stickers of Brazil for 6.00 lv. | Пепи избира страна **Бразилия** и сувенир **стикери** =\&gt; цената на един стикер на Бразилия е **1.20** =\&gt;Общата сума, която трябва да заплати е : **5 \* 1.20 = 6.00** |
| **Вход** | **Изход** | **Вход** | **Изход** |
| Denmarkcaps8 | Pepi bought 8 caps of Denmark for 52.00 lv. | Croatiaflags13 | Pepi bought 13 flags of Croatia for 35.75 lv. |
| **Вход** | **Изход** | **Вход** | **Изход** |
| USAcaps18 | Invalid country! | Argentinashirts35 | Invalid stock! |