﻿## 17.Лаб: Вложени цикли



1. 5.Сграда

Напишете програма, която извежда на конзолата номерата на стаите в една сграда (в низходящ ред), като са изпълнени следните условия:

- На **всеки четен етаж има само офиси**
- На **всеки нечетен етаж има само апартаменти**
- Всеки **апартамент** се означава по следния начин : **А** { **номер на етажа** }{ **номер на апартамента** }, **номерата на апартаментите започват от 0.**
- Всеки **офис** се означава по следния начин : **О** { **номер на етажа** }{ **номер на офиса** }, **номерата на**** офисите ****също започват от 0.**
- **На последният етаж винаги има апартаменти** и те са по-големи от останалите, за това **пред номера им пише &#39;L&#39;, вместо &#39;А&#39;. Ако има само един етаж, то има само големи апартаменти!**

От конзолата се прочитат две **цели числа - броят на етажите и броят на стаите за един етаж.**

### Примерен вход и изход

| **Вход** | **Изход** | **Обяснения** |
| --- | --- | --- |
| 64 | L60 L61 L62 L63A50 A51 A52 A53O40 O41 O42 O43A30 A31 A32 A33O20 O21 O22 O23A10 A11 A12 A13 | Имаме общо 6 етажа, с по 4 стаи на етаж. Нечетните етажи имат само апартаменти, а четните само офиси. |
| **Вход** | **Изход** | **Вход** | **Изход** |
| 95 | L90 L91 L92 L93 L94O80 O81 O82 O83 O84A70 A71 A72 A73 A74O60 O61 O62 O63 O64A50 A51 A52 A53 A54O40 O41 O42 O43 O44A30 A31 A32 A33 A34O20 O21 O22 O23 O24A10 A11 A12 A13 A14 | 44 | L40 L41 L42 L43A30 A31 A32 A33O20 O21 O22 O23A10 A11 A12 A13 |

### Насоки

1. Прочетете входните данни – **цели числа** , които представляват **броя на етажите** и **стаите** на всеки един етаж, и ги запазете в променливи:

1. Създайте **for** -цикъл, който да итерира **броят на етажите от сградата**** в низходящ ред**:

1. Създайте вложен **for** -цикъл, който да итерира **броят на стаите за всеки етаж** :

1. Извършете множество проверки за **номера на етажа от итерацията на цикъла** и **принтирайте** правилния изход:

След изпълнение на всички итерации от цикъла за стаите на етажите, принтирайте нов ред.



