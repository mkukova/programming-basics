﻿# Упражнение: Повторения с цикли – while-цикъл


1.
# 4.
Стъпки

Габи иска да започне здравословен начин на живот и си е поставила за цел да върви **10 000 стъпки всеки ден**. Някои дни обаче е много уморена от работа и ще иска да се прибере преди да постигне целта си. Напишете програма, която **чете от конзолата по колко стъпки изминава** тя всеки път като излиза през деня и **когато постигне целта си да се изписва**&quot; **Goal**** reached ****!**  **Good**** job ****!**&quot;

Ако иска да се **прибере преди това** , тя ще въведе **командата**&quot; **Going**** home **&quot; и** ще въведе стъпките, които е извървяла докато се прибира **. След което, ако не е успяла да постигне целта си, на конзолата трябва да се изпише: &quot;** { ****разликата между стъпките**** } **** more ****steps**** to ****reach**** goal ****.**&quot;

### Примерен вход и изход

| **Вход** | **Изход** | **Вход** | **Изход** |
| --- | --- | --- | --- |
| 1000150020006500  | Goal reached! Good job! | 150030025003000Going home200 | 2500 more steps to reach goal. |
| **Вход** | **Изход** | **Вход** | **Изход** |
| 1500300025015482000Going home2000 | Goal reached! Good job! | 12525040003026784682 | Goal reached! Good job! |

**Насоки**

1. Създайтепроменлива от **целочислен тип** , през която **ще следите колко стъпки е извървяла Габи** , и **while** , който ще продължава **докато Габи не достигне целта си**.

1. При всяко повторение на цикъла прочетете по един ред от конзолата.

1. Проверете дали програмата е **получила вход** от конзолата **Going**** home **и ако е,** прибавяйте стъпките, които е извървяла до тях **, в противен случай,** прибавяйте стъпките, които е извървяла**.

1. В случая, в който Габи се прибира, проверете дали е достигнала целта си, ако не е успяла **намерете разликата между нейната цел и стъпките, които е успяла да извърви** , отпечатайте нужното съобщение и след това прекъснете цикъла чрез командата **break**.



