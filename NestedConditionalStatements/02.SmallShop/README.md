﻿# 1.Лаб: Вложени условни конструкции

Задачи за упражнение в клас и за домашно към курса [&quot;Основи на програмирането&quot; @ СофтУни](https://softuni.bg/courses/programming-basics).

**Тествайте** решението си в **judge**  **системата** :[https://judge.softuni.bg/Contests/Compete/Index/1013#0](https://judge.softuni.bg/Contests/Compete/Index/1013#0)


1. 2.Квартално магазинче

Предприемчив българин отваря **квартални магазинчета** в **няколко града** и продава на **различни цени според града** :

| град / продукт | **coffee** | **water** | **beer** | **sweets** | **peanuts** |
| --- | --- | --- | --- | --- | --- |
| **Sofia** | 0.50 | 0.80 | 1.20 | 1.45 | 1.60 |
| **Plovdiv** | 0.40 | 0.70 | 1.15 | 1.30 | 1.50 |
| **Varna** | 0.45 | 0.70 | 1.10 | 1.35 | 1.55 |

Напишете програма, която чете **продукт** (низ), **град** (низ) и **количество** (десетично число), въведени от потребителя, и пресмята и отпечатва **колко струва** съответното количество от избрания продукт в посочения град.

### Примерен вход и изход

| **вход** | **изход** |   | **вход** | **изход** |   | **вход** | **изход** |   | **вход** | **изход** |   | **вход** | **изход** |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| coffeeVarna2 | 0.9 | peanutsPlovdiv1 | 1.5 | beerSofia6 | 7.2 | waterPlovdiv3 | 2.1 | sweetsSofia2.23 | 3.2335 |

### Насоки

1. Създайте нов проект във Visual Studio
2. Отидете в тялото на метода **Main(string[]****args) **и напишете решението на задачата, като pърво прочетете входните данни от конзолата, създайте си и една променлива** price**, като й зададете стойност &quot;0&quot;.

1. Направете серия от проверки, като за всеки град проверете за дадения продукт. Във всяка проверка за продукт, променяйте стойността на променливата **price** и я принтирайте. Вижте примера по-долу:

1. Тествайте решението си с различни входни стойности:

