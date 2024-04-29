**Лабораторна робота 3.**  

**РОЗРОБКА ДОДАТКІВ ІЗ ВИКОРИСТАННЯМ БАЗОВИХ ЕЛЕМЕНТІВ**  

**ОБ'ЄКТНО – ОРІЄНТОВАНОГО ПРОГРАМУВАННЯ**  

**Мета роботи:** Придбання практичних навичок використанням базових елементів  об‘єктно-орієнтованого  програмування  (ООП)  під  час  розробки консольних додатків мовою C#**.**   

**Короткі теоретичні відомості** ООП 

основане на трьох основних принципах:   

1. Інкапсуляція – об'єднання в єдине ціле (клас) даних і алгоритмів 

обробки цих даних. В ООП дані називаються полями, а алгоритми – методами.   

2. Спадкування  –  можливість  створення  ієрархії  класів,  коли 

класинащадки отримують від класа-попередника поля й методи.   

3. Поліморфізм (від гр. poly - багато і morphos – форма, означає багато 

форм)  –  це  властивість  класів  однієї  ієрархії  вирішувати  схожі  за  змістом завдання за допомогою різних алгоритмів.   

*Класи**   

Класи – це основний спосіб організації даних у C#. Будь-яка програма, що написана цією мовою, повинна складатися не менш чим із одного класу (отже C# є "справжньою" об'єктно-орієнтованою мовою, на відміну, скажімо, від С++, у якому використання класів можливе, але необов'язково). *Функції в мові C#*   

Будь-яка функція повинна бути членом класу (методом). Методи можуть приймати або не приймати параметри, повертати або не повертати значення. Параметри можуть передаватися в методи за значенням або за посиланням.  

Методи можуть бути статичними або методами екземплярів класу (об'єктів).   

*Модифікатори**   

Одним  з  важливих  принципів  об'єктно-орієнтованого  підходу  до програмування є інкапсуляція даних: вважається, що внутрішній устрій класу й конкретна  реалізація  його  методів  повинні  бути  невідомі  зовнішнім споживачам. Для виразу різних рівнів доступності елементів програми в C# існує обширний набір модифікаторів. Наприклад, поля та методи можуть мати таки основні модифікатори доступу:    

public  (даний  елемент  класу  доступний  усім  зовнішнім  споживачам); private  (елемент  недоступний  за  межами  опису  класу;  цей  модифікатор ставиться  за  умовчанням);   internal  (елемент  доступний  тільки  для  класів, визначених у тій же збірці,  

що і даний клас).   

Крім  того,  існують  модифікатори,  що  змінюють  поведінку  елементів 

класу, наприклад:   

const (свідчить, що дана змінна не може бути змінена);   

readonly (описує змінні, які можуть набути значення тільки при самому  

описі або в конструкторі класу);   static (вказує, що даний елемент належить типу 

об'єкта, а не конкретному  

екземпляру).   

` `Приклад програми, у якій є клас Hero,  наведений нижче:    

class Hero 

{     private int Age;      private 

string Name;      private 

readonly bool Alive; 

`    `// Конструктор  

`    `public Hero(int Age, string Name) 

`    `{ 

`        `this.Age = Age; this.Name = Name;         Alive = true; 

`    `} 

`    `public int GetAge() { return Age; }     

public string GetName() { return Name; }     

public bool IsAlive() { return Alive; }     

public static void Hobby() {/\*...\*/}     public 

void Talk() { /\*...\*/} 

`    `/\*...\*/ 

} 

`       `// Створення об'єкта класу  Hero  

`        `Hero LittleHero = new Hero(19, "Student"); 

`        `Console.WriteLine(LittleHero.GetName() + ", " +         LittleHero.GetAge() + ", " + LittleHero.IsAlive()); 

`    `*Ключове  слово  this*  є  посиланням  на  поточний  екземпляр  об'єкта; посилання this є схованим покажчиком, що передається в кожний нестатичний метод класу;  будь-який метод може використовувати this для доступу до інших нестатичних методів і змінних цього об'єкта.   

*Конструктори класів*   

Конструктор – метод, який ініціалізує стан об'єкта після його створення. Конструктор  має  те  ж  ім'я,  що  й  клас,  у  якому  він  використовується; конструктор не повертає значення (навіть типу void), конструктор викликається автоматично.   

Якщо конструктор не заданий у програмі, то він буде автоматично згенерований компілятором  для  побудови  відповідних  об'єктів,  конструктор  можна 

перевантажувати.   

` `*Статичні методи класу та конструктори*  

Статичний конструктор, як і всі статичні методи класу,  пов'язаний з класом,  а  не  з  об'єктом  і  необхідний  для  ініціалізації  статичних  даних.  У статичного конструктора існує цілий ряд особливостей:  

у класі може бути лише один статичний конструктор;  

при оголошенні статичного конструктора не можна передавати параметри  

та  не  можна  вказувати  модифікатори  доступу;  статичний  конструктор 

виконується лише один раз, незалежно від  

кількості  створених  об'єктів  даного  класу;  статичний  конструктор  буде викликаний до будь-якого першого звернення до цього класу (зазвичай перед першим викликом будь-якого члена класу); статичний конструктор ніколи не викликається ніяким іншим кодом, а  

лише середовищем, що виконує .NET під час завантаження класу; статичний 

конструктор має доступ лише до статичних членів класу.  

Для  прикладу  зі  статичним  конструктором  створимо  клас,  що  описує банківські філії, статичне поле міститиме бонус у відсотках для оформлення депозитів, поточний баланс у кожної філії буде свій.  

class Bank 

`    `{ 

`        `private double \_currBalance;         

private static double \_bonus;         public Bank(double balance) 

`        `{ 

`            `\_currBalance = balance; 

`        `}         static 

Bank() 

`        `{ 

`            `\_bonus = 1.04; 

`        `} 

`        `public static void SetBonus(double newRate)         { 

`            `\_bonus = newRate; 

`        `} 

`        `public static double GetBonus() 

`        `{             return 

\_bonus; 

`        `} 

`        `public void SetВаlance(double newBalance) 

`        `{ 

`            `\_currBalance = newBalance; 

`        `} 

`        `public double GetBalance() 

`        `{ 

`            `return \_currBalance; 

`        `} 

`        `public double GetPercents() 

`        `{ 

`                `double percent = \_currBalance \* \_bonus;                 return percent; 

`                `}     } 

Bank b1 = new Bank(10000); 

WriteLine("Поточний баланс:" + b1.GetBalance()); WriteLine("Поточний бонусний відсоток:" + Bank.GetBonus()); WriteLine("Сума з урахуванням відсотків:" + b1.GetPercents()); 

*Масиви об'єктів у С#**   

Класи є користувацькими типами даних, але за своїми властивоятями не відрізняються від стандартних класів С# *і можуть утворювати масиви.* Далі наведений фрагмент програми, в якому створюється масив для зберігання двох об‘єктів  класу  MyClass  та  два  об‘єкта  цього  класу  додаються  до  масиву:  

MyClass[] ArrayOfObject = new MyClass[2];  for (int i = 0; i < ArrayOfObject.Length; i++) 

`    `ArrayOfObject[i] = new MyClass(); 

class MyClass {/\*….\*/} 

**Завдання до лабораторної  роботи** **Завдання** 

**1.**  

Загальні вимоги до розроблювальних програм: наявність найпростішого текстового інтерфейсу користувача; розробка програми для обробки відомості (див. варіанти завдань).   

Для цього необхідно описати клас, поля якого відповідають вихідним полям  відомості.  Для  установки  значень  полів  повинен  використовуватися конструктор. Обчислення значень розрахункових полів відомості, одержання значень  вихідних  полів  повинне  виконуватися  за  допомогою  відповідних нестатичних методів класу.    

Програма повинна забезпечувати створення масиву об'єктів цього  класу, уведення вихідних даних з консолі й вивід на консоль вихідних значень і полів, що розраховуються, кожної із записів відомості, а також підсумкової інформації 

з відомості.   
**
` `Варіант 1 Відомість нарахування зарплати співробітникам підприємства:   

|№ з/п  |Прізвище |Зарплата, грн  |Утримано, грн  |Видано, грн  |
| - | - | - | - | - |
|1  |F   |Z  |P  |S = Z – P  |
|2  |||||
|…  |||||
||Разом  |![ref1]|![ref1]|![ref1]|

` `Варіант 2 Відомість витрат палива на автобазах міста:   

|№ з/п  |Автобаза  |Витрачено палива, кг  |Кількість автомашин, шт.  |Середня витрата палива, кг  |
| - | - | - | - | :- |
|1  |A  |T  |K  |C = T/K  |
|2  |||||
|…  |||||
|n  |||||
||Разом  |![ref2]|![ref2]|/n  ![ref3]|

Варіант 3. Відомість використання часу в науковому центрі:   

<table><tr><th colspan="1" rowspan="2" valign="top">№ з/п  </th><th colspan="1" rowspan="2" valign="top">Кафедра</th><th colspan="2" valign="top">Використання часу на експериментальній установці, годин  </th><th colspan="2" valign="top">Відхилення від плану  </th></tr>
<tr><td colspan="1" valign="top">за планом  </td><td colspan="1" valign="top">фактично  </td><td colspan="1" valign="top">у годинах  </td><td colspan="1" valign="top">у %  </td></tr>
</table>



|1  |K  |P  |F  |O1 = P-F  |O2 = O1 × 100/P  |
| - | - | - | - | - | - |
|2  ||||||
|…||||||
||Разом  |![ref4]|![ref4]|||
` `Варіант 4. Відомість споживання електроенергії на заводах міста: 

<table><tr><th colspan="1" rowspan="2" valign="top">` `№ з/п  </th><th colspan="1" rowspan="2" valign="top">Завод  </th><th colspan="2" valign="top">Споживання електроенергії, кВт/год. </th><th colspan="2" valign="top">Відхилення від плану  </th></tr>
<tr><td colspan="1" valign="top">за планом  </td><td colspan="1" valign="top">фактично  </td><td colspan="1" valign="top">у кВт/год.  </td><td colspan="1" valign="top">у %  </td></tr>
<tr><td colspan="1" valign="top">1  </td><td colspan="1" valign="top">Z  </td><td colspan="1" valign="top">P  </td><td colspan="1" valign="top">F  </td><td colspan="1" valign="top">O1= P-F  </td><td colspan="1" valign="top">O2=O1×100/P  </td></tr>
<tr><td colspan="1" valign="top">2  </td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td></tr>
<tr><td colspan="1" valign="top">…  </td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td></tr>
<tr><td colspan="1"></td><td colspan="1" valign="top">Разом  </td><td colspan="1" valign="top">![ref5]</td><td colspan="1" valign="top">![ref5]</td><td colspan="1"></td><td colspan="1"></td></tr>
</table>
Варіант 5 Відомість руху матеріалів на складі підприємства за звітний 

період:   

||Склад  |Рух матеріалів за період, грн  ||||
| :- | - | - | :- | :- | :- |
|№ з/п  ||залишок на початок періоду  |отримано  |видано  |Залишок на кінець періоду  |
|1  |С  |Ос  |P  |V  |R = Oc + P – V  |
|2  ||||||
|…  ||||||
||Разом  |![ref6]|![ref6]|![ref6]|![ref6]|

` `Варіант  6.   Відомість  прибутку  підприємства  за  звітний  період  за  видами продукції:   

|№ з/п  |Продукція |`   `Кількість, шт.  |Оптова ціна, грн  |Собівартість, грн  |Прибуток, грн  |
| - | - | - | - | - | - |
|1  |Pr  |K  |Z  |C  |P = K(Z – C)  |
|2  ||||||
|…  ||||||
||Разом  |![ref7]|||![ref7]|

Варіант 7. Відомість відвідування занять студентами:   

<table><tr><th colspan="1" rowspan="2" valign="top">№ з/п  </th><th colspan="1" rowspan="2" valign="top">Прізвище  </th><th colspan="2" valign="top">Пропущено, год.  </th><th colspan="2" valign="top">Пропуск  </th></tr>
<tr><td colspan="1" valign="top">усього  </td><td colspan="1" valign="top">виправдано  </td><td colspan="1" valign="top">у годинах  </td><td colspan="1" valign="top">у %  </td></tr>
<tr><td colspan="1" valign="top">1  </td><td colspan="1" valign="top">F  </td><td colspan="1" valign="top">V  </td><td colspan="1" valign="top">O  </td><td colspan="1" valign="top">P1 = V – O  </td><td colspan="1" valign="top">P2 = P1∙× 100/V  </td></tr>
<tr><td colspan="1" valign="top">2  </td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td></tr>
<tr><td colspan="1" valign="top">…  </td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td></tr>
</table>


||Разом:  |![ref8]|![ref8]|![ref8]||
| :- | - | - | - | - | :- |
` `Варіант 8.  

Відомість обсягу поставок продукції в натуральному та вартісному виразах:   

|` `№ з/п  |Продукція  |Шифр  |Обсяг постачань, шт.  |Оптова ціна, грн  |Обсяг постачань, грн  |
| :- | - | - | :- | - | :- |
|1  |P  |H  |V  |Z  |O = V × Z  |
|2  ||||||
|…  ||||||
||Разом  ||![ref9]|![ref9]|![ref9]|

` `Варіант  9.  Відомість  розрахунку  середньої  вартості  перевезення авіапасажирів:   

|<p>№ </p><p>з/п  </p>|Тип літака  |Рейс  |Витрати на рейс, грн.  |Кількість пасажирів  |Середня вартість перевезення, грн.  |
| - | - | - | :- | - | :- |
|1  |T  |R  |Z  |K  |S = Z/K  |
|2  ||||||
|…  ||||||
|n  ||||||
||Разом:  ||![ref10]|![ref10]|/n    ![ref3]|

Варіант 10. Відомість обліку часу роботи верстатів підприємства:   

<table><tr><th colspan="1" rowspan="2" valign="top">№ з/п  </th><th colspan="1" rowspan="2" valign="top">Тип верстата  </th><th colspan="2" valign="top">Час роботи, год.  </th><th colspan="2" valign="top">Відхилення від плану  </th></tr>
<tr><td colspan="1" valign="top">за планом  </td><td colspan="1" valign="top">фактично  </td><td colspan="1" valign="top">у годинах  </td><td colspan="1" valign="top">у %  </td></tr>
<tr><td colspan="1" valign="top">1  </td><td colspan="1" valign="top">Z  </td><td colspan="1" valign="top">P  </td><td colspan="1" valign="top">F  </td><td colspan="1" valign="top">O1 = P-F  </td><td colspan="1" valign="top">O2 = O1 × 100/P  </td></tr>
<tr><td colspan="1" valign="top">2  </td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td></tr>
<tr><td colspan="1" valign="top">…</td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td></tr>
<tr><td colspan="1"></td><td colspan="1" valign="top">Разом  </td><td colspan="1" valign="top">![ref11]</td><td colspan="1" valign="top">![ref11]</td><td colspan="1"></td><td colspan="1"></td></tr>
</table>
Варіант 11. Відомість випуску деталей робітниками цеху:   

<table><tr><th colspan="1"></th><th colspan="1" valign="top">Прізвище  </th><th colspan="2" valign="top">Кількість деталей, шт.  </th><th colspan="1" valign="top">Брак  </th><th colspan="1"></th></tr>
<tr><td colspan="1" rowspan="2" valign="top">№ з/п  </td><td colspan="1" rowspan="2"></td><td colspan="2"></td><td colspan="1"></td><td colspan="1"></td></tr>
<tr><td colspan="1" valign="top">виготовлено  </td><td colspan="1" valign="top">прийнято  </td><td colspan="1" valign="top">шт.  </td><td colspan="1" valign="top">%  </td></tr>
<tr><td colspan="1" valign="top">1  </td><td colspan="1" valign="top">Z  </td><td colspan="1" valign="top">P  </td><td colspan="1" valign="top">F  </td><td colspan="1" valign="top">O1 = P-F  </td><td colspan="1" valign="top">O2=O1×100/P  </td></tr>
<tr><td colspan="1" valign="top">2  </td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td></tr>
<tr><td colspan="1" valign="top">…</td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td></tr>
<tr><td colspan="1"></td><td colspan="1" valign="top">Разом  </td><td colspan="1" valign="top">![ref12]</td><td colspan="1" valign="top">![ref12]</td><td colspan="1" valign="top">![ref12]</td><td colspan="1"></td></tr>
</table>
Варіант 12. Відомість наявності та руху основних фондів підприємства:   



|№ |` `Назва фонду  |Наявність на початок року, шт.  ||Поступило, шт.  |Виб  уло, шт.  |Наявність на кінець року, шт.  |
| - | :- | :- | :- | - | :- | :- |
|з/п  |||||||
|1  |F  |N1  ||P  |V |N2 =  N1 + P – V  |
|2  |||||||
|…  |||||||
||Разом  |![ref13]||![ref13]|![ref13]|![ref13]|

Варіант 13. Відомість витрат палива на автобазах міста:   

|` `№ з/п  |Автобаза  |<p>Витрачено палива, </p><p>кг  </p>|Кількість автомашин, шт.  ||Середня витрата палива, кг  |
| :- | - | - | :- | :- | :- |
|1  |A  |T  |K  ||C = T/K  |
|2  ||||||
|…  ||||||
|n  ||||||
||Разом  |![ref14]|![ref14]||/n    ![ref3]|

Варіант 14. Відомість використання часу в науковому центрі:   

||Кафедра  |Використання часу на експериментальній установці, годин  |Відхилення від плану  |||
| :- | - | :- | - | :- | :- |
|№ з/п  ||за планом  |фактично  |у годинах  |у %  |
|1  |K  |P  |F  |O1 = P-F  |O2 = O1 × 100/P  |
|2  ||||||
|… ||||||
||Разом  |![ref15]|![ref15]|||
Варіант 15. Відомість споживання електроенергії на заводах міста:   

<table><tr><th colspan="1" rowspan="2" valign="top">` `№ з/п  </th><th colspan="1" rowspan="2" valign="top">Завод  </th><th colspan="2" valign="top">Споживання електроенергії, кВт/год.  </th><th colspan="2" valign="top">Відхилення від плану  </th></tr>
<tr><td colspan="1" valign="top">за планом  </td><td colspan="1" valign="top">фактично  </td><td colspan="1" valign="top">у кВт/год.  </td><td colspan="1" valign="top">у %  </td></tr>
<tr><td colspan="1" valign="top">1  </td><td colspan="1" valign="top">Z  </td><td colspan="1" valign="top">P  </td><td colspan="1" valign="top">F  </td><td colspan="1" valign="top">O1= P-F  </td><td colspan="1" valign="top">O2=O1×100/P  </td></tr>
<tr><td colspan="1" valign="top">2  </td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td></tr>
<tr><td colspan="1" valign="top">…  </td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td></tr>
<tr><td colspan="1"></td><td colspan="1" valign="top">Разом  </td><td colspan="1" valign="top">![ref16]</td><td colspan="1" valign="top">![ref16]</td><td colspan="1"></td><td colspan="1"></td></tr>
</table>
Варіант 16.   Відомість  прибутку  підприємства  за  звітний  період  за  видами продукції:   

|№ з/п  |Продукція |`   `Кількість, шт.  |Оптова ціна, грн  |Собівартість, грн  |Прибуток, грн  |
| - | - | - | - | - | - |
|1  |Pr  |K  |Z  |C  |P = K(Z – C)  |



|2  ||||||
| - | :- | :- | :- | :- | :- |
|…  ||||||
||Разом  |![ref17]|||![ref17]|

Варіант 17. Відомість відвідування занять студентами:   

<table><tr><th colspan="1"></th><th colspan="1" valign="top">Прізвище  </th><th colspan="2" valign="top">Пропущено, год.  </th><th colspan="1" valign="top">Пропуск  </th><th colspan="1"></th></tr>
<tr><td colspan="1" rowspan="2" valign="top">№ з/п  </td><td colspan="1" rowspan="2"></td><td colspan="2"></td><td colspan="1"></td><td colspan="1"></td></tr>
<tr><td colspan="1" valign="top">усього  </td><td colspan="1" valign="top">виправдано  </td><td colspan="1" valign="top">у годинах  </td><td colspan="1" valign="top">у %  </td></tr>
<tr><td colspan="1" valign="top">1  </td><td colspan="1" valign="top">F  </td><td colspan="1" valign="top">V  </td><td colspan="1" valign="top">O  </td><td colspan="1" valign="top">P1 = V – O  </td><td colspan="1" valign="top">P2 = P1∙× 100/V  </td></tr>
<tr><td colspan="1" valign="top">2  </td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td></tr>
<tr><td colspan="1" valign="top">…  </td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td></tr>
<tr><td colspan="1"></td><td colspan="1" valign="top">Разом:  </td><td colspan="1" valign="top">![ref17]</td><td colspan="1" valign="top">![ref17]</td><td colspan="1" valign="top">![ref17]</td><td colspan="1"></td></tr>
</table>
` `Варіант 18.  

Відомість обсягу поставок продукції в натуральному та вартісному виразах:   

|<p>` `№ </p><p>з/п  </p>|Продукція  |Шифр  |Обсяг постачань, шт.  |Оптова ціна, грн  |Обсяг постачань, грн  |
| - | - | - | :- | - | :- |
|1  |P  |H  |V  |Z  |O = V × Z  |
|2  ||||||
|… ||||||
||Разом  ||![ref18]|![ref18]|![ref18]|

` `Варіант  19.  Відомість  розрахунку  середньої  вартості  перевезення авіапасажирів:   

|№ з/п  |Тип літака  |Рейс  |Витрати на рейс, грн.  |Кількість пасажирів  |Середня вартість перевезення, грн.  |
| :- | - | - | :- | - | :- |
|1  |T  |R  |Z  |K  |S = Z/K  |
|2  ||||||
|…  ||||||
|n  ||||||
||Разом:  ||![ref19]|![ref19]|/n    ![ref3]|

Варіант 20. Відомість обліку часу роботи верстатів підприємства:   

<table><tr><th colspan="1" rowspan="2" valign="top">№ з/п  </th><th colspan="1" rowspan="2" valign="top">Тип верстата  </th><th colspan="2" valign="top">Час роботи, год.  </th><th colspan="2" valign="top">Відхилення від плану  </th></tr>
<tr><td colspan="1" valign="top">за планом  </td><td colspan="1" valign="top">фактично  </td><td colspan="1" valign="top">у годинах  </td><td colspan="1" valign="top">у %  </td></tr>
<tr><td colspan="1" valign="top">1  </td><td colspan="1" valign="top">Z  </td><td colspan="1" valign="top">P  </td><td colspan="1" valign="top">F  </td><td colspan="1" valign="top">O1 = P-F  </td><td colspan="1" valign="top">O2 = O1 × 100/P  </td></tr>
<tr><td colspan="1" valign="top">2  </td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td></tr>
<tr><td colspan="1" valign="top">…</td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td><td colspan="1"></td></tr>
</table>


||Разом  |![ref20]|![ref20]|||
| :- | - | - | - | :- | :- |
Код програми: 

using System; 

namespace lab3\_1 { 

`    `public class Manufacture 

`    `{ 

`        `public List<object> machines = new List<object>(); 

`        `public void addMachine(Machine machine)          { 

`            `machines.Add(machine); 

`        `} 

`        `public void printMachines() 

`        `{ 

`            `foreach (var machine in machines) 

`            `{ 

`                `Machine m = (Machine)machine; 

`                `Console.WriteLine($"Type: {m.type}, Plan Time: {m.plan\_time}, Actual Time: {m.actual\_time}"); 

`            `} 

`        `} 

`        `public int sumPlanTime() 

`        `{ 

`            `int sum = 0; 

`            `foreach (var machine in machines)             { 

`                `Machine m = (Machine)machine;                 sum += m.plan\_time; 

`            `} 

`            `return sum; 

`        `} 

`        `public int sumActualTime() 

`        `{ 

`            `int sum = 0; 

`            `foreach (var machine in machines)             { 

`                `Machine m = (Machine)machine;                 sum += m.actual\_time; 

`            `} 

`            `return sum; 

`        `} 

} 

`    `public class Machine 

`    `{ 

`        `public string type { get; set; } 

`        `public int plan\_time { get; set; }         public int actual\_time { get; set; } 

`        `public double CalculateDeviation() 

`        `{ 

`            `return Math.Abs(plan\_time - actual\_time);         } 

`    `} 

`    `class Program 

`    `{ 

`        `static void Main(string[] args) 

`        `{ 

`            `Machine m1 = new Machine() { type = "Z", plan\_time = 2, actual\_time = 1 }; 

`            `Console.WriteLine($"Deviation is {m1.CalculateDeviation()} hour(s)"); 

`            `Machine m2 = new Machine() { type = "Z", plan\_time = 2, actual\_time = 2 }; 

`            `Console.WriteLine($"Deviation is {m2.CalculateDeviation()} hour(s)"); 

Manufacture man1 = new Manufacture(); man1.addMachine(m1); man1.addMachine(m2); 

man1.printMachines(); 

`            `Console.WriteLine($"Sum of plan time is {man1.sumPlanTime()} hour(s)"); 

`            `Console.WriteLine($"Sum of actual time is {man1.sumActualTime()} hour(s)"); 

`        `} 

`    `} 

} 

![](Aspose.Words.49538c34-f066-44f4-83cd-9cb4ef756ca6.021.png)

Рисунок 3.1 – Результат роботи програми 

**Завдання 2 (загальне).**  

Створіть клас «Місто». Необхідно зберігати у полях класу: назву міста, назву країни, кількість жителів у місті, поштовий індекс міста, назви районів міста. Окремі статичні поля повинні зберігати кількість об’єктів створених міст та  загальну  кількість  жителів  створених  міст.  Реалізуйте  методи  класу  для введення даних, виведення даних. Реалізуйте доступ до окремих полів через методи класу.   

Код програми: 

using System; 

namespace lab3\_2 { 

`    `public class City 

`    `{ 

`        `private string \_cityName; 

`        `private string \_countryName;         private int \_population; 

`        `private int \_postalCode; 

`        `private string[] \_districts;         private int \_cityCount; 

`        `private int \_totalPopulation; 

`        `public City(string cityName, string countryName, int population, int postalCode, string[] districts) 

`        `{ 

`            `\_cityName = cityName; 

`            `\_countryName = countryName; 

`            `\_population = population; 

`            `\_postalCode = postalCode; 

`            `\_districts = districts; 

`            `\_cityCount++; 

`            `\_totalPopulation += population;         } 

`        `public string GetCityName() 

`        `{ 

`            `return \_cityName; 

`        `} 

`        `public void SetCityName(string cityName)         { 

`            `\_cityName=cityName; 

`        `} 

`        `public string GetCountryName() 

`        `{ 

`            `return \_countryName; 

`        `} 

`        `public void SetCountryName(string countryName)         { 

`            `\_countryName=countryName; 

`        `} 

`        `public int GetPopulation() 

`        `{ 

`            `return (int) \_population; 

`        `} 

`        `public void SetPopulation(int population)         { 

`            `\_population=population; 

`        `} 

`        `public int GetPostalCode() 

`        `{ 

`            `return (int) \_postalCode; 

`        `} 

`        `public void SetPostalCode(int postalCode)         { 

`            `\_postalCode=postalCode; 

`        `} 

`        `public string[] GetDistricts() 

`        `{ 

`            `return \_districts; 

`        `} 

`        `public void SetDistricts(string[] districts)         { 

`            `\_districts=districts; 

} 

`        `public int GetCityCount() 

`        `{ 

`            `return \_cityCount; 

`        `} 

`        `public int GetTotalPopulation()         { 

`            `return \_totalPopulation; 

`        `} 

`        `public void InputData() 

`        `{ 

`            `Console.Write("Введіть назву міста: ");             \_cityName = Console.ReadLine(); 

Console.Write("Введіть назву країни: "); \_countryName = Console.ReadLine(); 

Console.Write("Введіть кількість жителів: "); \_population = int.Parse(Console.ReadLine()); Console.Write("Введіть поштовий індекс: "); \_postalCode = int.Parse(Console.ReadLine()); 

Console.Write("Введіть кількість районів: "); 

int districtCount = int.Parse(Console.ReadLine()); 

\_districts = new string[districtCount]; 

`            `for (int i = 0; i < districtCount; i++) 

`            `{ 

`                `Console.Write($"Введіть назву району {i + 1}: ");                 \_districts[i] = Console.ReadLine(); 

`            `} 

`        `} 

`        `public void OutputData() 

`        `{ 

`            `Console.WriteLine($"\nМісто: {\_cityName}"); 

`            `Console.WriteLine($"Країна: {\_countryName}"); 

`            `Console.WriteLine($"Кількість жителів: {\_population}");             Console.WriteLine($"Поштовий індекс: {\_postalCode}");             Console.WriteLine("Райони:"); 

`            `foreach (string district in \_districts)             { 

`                `Console.WriteLine($"- {district}");             } 

`        `} 

`    `} 

`    `class Program 

`    `{ 

`        `static void Main() 

`        `{ 

`            `City Kremenchuk = new City("Kremenchuk", "Ukraine", 250000, 39600, ["Rakivka", "Molodizhniy", "Centr", "Rynok"]); 

`            `Kremenchuk.OutputData(); 

`        `} 

`    `} 

}

![](Aspose.Words.49538c34-f066-44f4-83cd-9cb4ef756ca6.022.png)

Рисунок 3.2 – Результат роботи програми з класом “Місто” 

***Контрольні питання***  

1. Принципи об'єктно-орієнтованого програмування: 

Інкапсуляція: Об'єднання даних та методів в об'єктах, приховування деталей реалізації. 

Успадкування: Створення нових класів на основі існуючих, з успадкуванням властивостей та методів. 

Поліморфізм: Здатність об'єктів різних класів реагувати на однакові повідомлення по-різному. 

Абстракція: Виокремлення суттєвих характеристик об'єкта та ігнорування деталей. 

2. Поняття класу й об'єкта, співвідношення між ними: 

Клас: Шаблон для створення об'єктів, що описує їхні властивості та поведінку. Об'єкт: Екземпляр класу, що містить дані та методи, specific for this instance. Співвідношення: Клас - це модель, а об'єкт - це екземпляр цієї моделі. 

3. Життєвий цикл об'єкта в програмі: 

Створення: Виділення пам'яті та ініціалізація даних об'єкта. 

Використання: Доступ до даних та методів об'єкта, виконання дій. 

Видалення: Звільнення пам'яті, що використовується об'єктом. 

4. Призначення й варіанти використання посилання this: 

Призначення: Доступ до екземпляра класу з його методів. 

Варіанти використання: 

Доступ до полів та методів класу. 

Передача посилання на об'єкт як аргумент методу. 

Використання в операторах порівняння. 

5. Що означає перевантаження методу: 

Перевантаження: Наявність в класі декількох методів з однаковою назвою, але з різними наборами параметрів. 

Призначення: Дозволяє використовувати один і той же метод для роботи з різними типами даних. 

6. Призначення конструктора: 

Призначення: Ініціалізація даних об'єкта при його створенні. Особливості: 

Має ту ж назву, що й клас. 

Не має типу повернення. 

Може мати різні параметри для ініціалізації даних. 

7. Основні особливості конструктора: 

Виклик: Автоматично викликається при створенні об'єкта. Модифікатор доступу: Зазвичай public. 

Кількість: Може бути кілька конструкторів з різними параметрами. 

Дефолтний конструктор: Автоматично генерується, якщо не визначено жодного. 

[ref1]: Aspose.Words.49538c34-f066-44f4-83cd-9cb4ef756ca6.001.png
[ref2]: Aspose.Words.49538c34-f066-44f4-83cd-9cb4ef756ca6.002.png
[ref3]: Aspose.Words.49538c34-f066-44f4-83cd-9cb4ef756ca6.003.png
[ref4]: Aspose.Words.49538c34-f066-44f4-83cd-9cb4ef756ca6.004.png
[ref5]: Aspose.Words.49538c34-f066-44f4-83cd-9cb4ef756ca6.005.png
[ref6]: Aspose.Words.49538c34-f066-44f4-83cd-9cb4ef756ca6.006.png
[ref7]: Aspose.Words.49538c34-f066-44f4-83cd-9cb4ef756ca6.007.png
[ref8]: Aspose.Words.49538c34-f066-44f4-83cd-9cb4ef756ca6.008.png
[ref9]: Aspose.Words.49538c34-f066-44f4-83cd-9cb4ef756ca6.009.png
[ref10]: Aspose.Words.49538c34-f066-44f4-83cd-9cb4ef756ca6.010.png
[ref11]: Aspose.Words.49538c34-f066-44f4-83cd-9cb4ef756ca6.011.png
[ref12]: Aspose.Words.49538c34-f066-44f4-83cd-9cb4ef756ca6.012.png
[ref13]: Aspose.Words.49538c34-f066-44f4-83cd-9cb4ef756ca6.013.png
[ref14]: Aspose.Words.49538c34-f066-44f4-83cd-9cb4ef756ca6.014.png
[ref15]: Aspose.Words.49538c34-f066-44f4-83cd-9cb4ef756ca6.015.png
[ref16]: Aspose.Words.49538c34-f066-44f4-83cd-9cb4ef756ca6.016.png
[ref17]: Aspose.Words.49538c34-f066-44f4-83cd-9cb4ef756ca6.017.png
[ref18]: Aspose.Words.49538c34-f066-44f4-83cd-9cb4ef756ca6.018.png
[ref19]: Aspose.Words.49538c34-f066-44f4-83cd-9cb4ef756ca6.019.png
[ref20]: Aspose.Words.49538c34-f066-44f4-83cd-9cb4ef756ca6.020.png
