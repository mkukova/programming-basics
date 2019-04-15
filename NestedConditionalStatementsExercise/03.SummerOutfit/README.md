# 1.Упражнения: Вложени условни конструкции

1. 3. Лятно облекло

Лято е с много променливо време и Виктор има нужда от вашата помощ. Напишете програма която **спрямо времето от денонощието**** и градусите **да препоръча на Виктор какви дрехи да си облече. Вашия приятел има различни планове за всеки етап от деня, които изискват и различен външен вид, тях може да видите от** таблицата.**

**От конзолата се четат точно два реда:**

- **Градусите - цяло число в интервала** **[10…42]**
- **Текст**** , **** време от денонощието - ****с възможности - &quot;**** Morning ****&quot;**** , ****&quot; ****Afternoon****&quot; ****,**  **&quot;**** Evening ****&quot;**

| **Време от денонощието / градуси** |  Мorning |  Afternoon |  Evening |
| --- | --- | --- | --- |
| 10 \&lt;= градуси \&lt;= 18 | Outfit = SweatshirtShoes = Sneakers | Outfit = ShirtShoes = Moccasins | Outfit = ShirtShoes = Moccasins |
| 18 \&lt; градуси \&lt;= 24 | Outfit = ShirtShoes = Moccasins | Outfit = T-ShirtShoes = Sandals | Outfit = ShirtShoes = Moccasins |
| градуси \&gt;= 25 | Outfit = T-ShirtShoes = Sandals | Outfit = Swim SuitShoes = Barefoot | Outfit = ShirtShoes = Moccasins |

**Да се отпечата на конзолата на един ред:****&quot; ****It****&#39; ****s**  **{градуси}**  **degrees**** , **** get ****your**  **{облекло}**  **and**  **{обувки}.&quot;**

### Примерен вход и изход

| **Вход** | **Изход** | **Обяснения** |
| --- | --- | --- |
| 16Morning | It&#39;s 16 degrees, get your Sweatshirt and Sneakers. | Сутрин когато градусите са 16,Виктор си взима суичър и маратонки. |
| **Вход** | **Изход** | **Вход** | **Изход** |
| 22Afternoon | It&#39;s 22 degrees, get your T-Shirt and Sandals. | 28Evening | It&#39;s 28 degrees, get your Shirt and Moccasins. |

### Насоки

1. Прочетете входните данни от конзолатаи инициализирайте две променливи &quot;utfit, shoes&quot; от тип &quot;string&quot;, с начална стойност &quot;string.Empty&quot;.

1. Направете проверка за градуситеизползвайки логически оператор &quot; **и**&quot; – &quot; **&amp;&amp;**&quot; -&quot; **degrees**  **\&gt;= 10 &amp;&amp;**  **degrees**  **\&lt;= 18**&quot; и в тялото на проверката за градусите проверявайте за времето от деня &quot; **Morning** , **Afternoon** , **Evening**&quot;, като за всеки етап от деня променяйте стойността на променливите &quot; **outfit** , **shoes**&quot;.

1. Отпечатайте на конзолата крайния резултат във формата описан в условието на задачата.

