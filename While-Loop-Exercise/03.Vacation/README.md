﻿# Упражнение: Повторения с цикли – while-цикъл

1.
# 3.
Почивка

Джеси е решила да събира пари за екскурзия и иска от вас да ѝ помогнете да разбере **дали ще успее да събере необходимата сума**. **Тя спестява** или **харчи част от**** парите **си** всеки ден **. Ако иска да** похарчи повече от наличните си пари **, то тя ще похарчи** колкото има и ще **** ѝ **** останат 0 лева**.

### Вход

От конзолата се четат:

- **Пари нужни за екскурзията** - **реално**** число в интервала [1.00..****.25000.00]**
- **Налични пари** - **реално**** число в интервала [0.00...****25000.00]**

**След това многократно се четат по два реда:**

- **Вид действие – текст с възможности &quot;**** spend ****&quot;**** и ****&quot; ****save****&quot;.**
  - **Сумата, която ще спести/похарчи - реално число в интервала [0.01…****25000.00****]**

### Изход

Програмата трябва да приключи при следните случаи:

- Ако **5 последователни дни** Джеси **само харчи, на конзолата да се изпише**** :**

- **oo****&quot; ****You can&#39;t save the money.****&quot;**
- **oo****&quot; ****{**** Общ брой изминали дни ****}****&quot;**

- **Ако**** Джеси събере парите за почивката **на** конзолата се изписва:**

- **oo****&quot; ****You saved the money for {**** общ брой изминали дни ****} days.****&quot;**

### Примерен вход и изход

| **Вход** | **Изход** | **Обяснения** |
| --- | --- | --- |
| 20001000spend1200save2000 | You saved the money for 2 days.  | Пари нужни за почивката:  2000Наличните пари:  1000spend – изваждаме от парите следващото число1200 - ние разполагаме с 1000, но се опитваме да похарчим 1200, тъй като не разполагаме с толкова, харчим наличните си 1000 и оставаме 0лева.save – прибавяме към парите следващото число2000 – разполагаме с 0, добавяме 2000 и събираме парите успешно за 2 дни. |
| 11060spend10spend10spend10spend10spend10 | You can&#39;t save the money.5 | 250150spend50spend50save100save100 | You saved the money for 4 days. |

### Насоки

1. Прочетете входните данни от конзолата.

1. Направете **две помощни променливи** в началото, които да следят **броя изминали дни и броя**  **последователни дни, в които Джеси харчи пари**. Променливите са от **целочислен тип** , с първоначална **стойност нула**.

1. Създайте **while** цикъл, който продължава докато парите на Джеси са по-малко от парите, които са ѝ нужни за екскурзията и брояча за последователните дни е по-малък от 5.

1. При **всяко повторение на цикъла** , четете от конзолата **два реда** и увеличавайте брояча за дните. Първият ред е текст -   **spend** или **save** , а вторият ред е **реално число** , парите които Джеси е спестила или похарчила.

1. Проверете дали Джеси **харчи или спестява** за дадения ден. Ако **спестява** прибавете спестените пари към нейните и **нулирайте брояча за поредните дни**. Ако **харчи** извадете от нейните пари, сумата която е похарчила, **увеличете брояча за поредните дни,** в които харчи. Проверете дали парите на Джеси са станали **по-малко от нула** и ако е така, то тя е останала без пари и има нула лева.

1. След цикъла проверете дали Джеси е харчила пари в **пет последователни дни** и принтирайте съобщението.

1. Проверете дали Джеси е **събрала парите** и ако е успяла принтирайте съобщението.

