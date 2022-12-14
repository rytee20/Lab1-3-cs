# Lab1-3-cs

Person
------
Определить класс Person, который имеет 
* закрытое поле типа string, в котором хранится имя;
* закрытое поле типа string, в котором хранится фамилия;
* закрытое поле типа System.DateTime для даты рождения.  

В классе Person определить конструкторы:
* конструктор c тремя параметрами типа string, string, DateTime для инициализации всех полей класса; 
* конструктор без параметров, инициализирующий все поля класса некоторыми значениями по умолчанию. 

В классе Person определить свойства c методами get и set:
* свойство типа string для доступа к полю с именем; 
* свойство типа string для доступа к полю с фамилией;
* свойство типа DateTime для доступа к полю с датой рождения;
* свойство типа int c методами get и set для получения информации(get) и изменения (set) года рождения в закрытом поле типа DateTime, в котором хранится дата рождения.  

В классе Person определить
* перегруженную(override) версию виртуального метода string ToString() для формирования строки со значениями всех полей класса;
* виртуальный метод string ToShortString(), который возвращает строку, содержащую только имя и фамилию.  

Cравнить время, необходимое для выполнения операций с элементами одномерного, двумерного прямоугольного и двумерного ступенчатого массивов с одинаковым числом элементов.  
Для этого в методе Main() создать 
* одномерный массив;
* двумерный прямоугольный массив;
* двумерный ступенчатый массив.  

Тип элементов массивов зависит от варианта лабораторной работы.
Массивы должны иметь одинаковое число элементов. Если число строк в 
двумерном прямоугольном массиве равно nrow, а число столбцов ncolumn, то 
одномерный массив должен содержать nrow*ncolumn элементов, в 
двумерном ступенчатом массиве общее число элементов также должно быть 
равно nrow*ncolumn.  
Значения nrow и ncolumn вводятся в процессе работы приложения в виде 
одной строки с разделителями. В приглашении, которое получает 
пользователь, должна быть информация о том, какие символы можно 
использовать как разделители, число разделителей должно быть больше 1. С 
помощью метода Split класса System.String приложение разбирает введенную 
пользователем текстовую строку с информацией о числе строк и числе 
столбцов двумерного массива и присваивает значения переменным, которые 
содержат значения nrow и ncolumn. В первой лабораторной работе не 
требуется обрабатывать ошибки ввода, предполагается, что пользователь 
правильно ввел данные.  
Приложение распределяет память для всех массивов и инициализирует
элементы массивов. Для инициализации элементов можно использовать 
конструктор без параметров.  
Для всех элементов массивов выполняется одна и та же операция, 
например, присваивается значение одному из свойств, определенных для 
элементов массива. В лабораторной работе требуется сравнить время 
выполнения этой операции для одномерного, двумерного прямоугольного и 
двумерного ступенчатого массивов с одинаковым числом элементов.  
Для измерения времени выполнения операций можно использовать 
свойство Environment.TickCount. Cтатическое свойство TickCount класса 
Environment имеет тип int, использует информацию системного таймера и 
содержит время в миллисекундах, которое прошло с момента перезагрузки 
компьютера.   
Чтобы получить время выполнения некоторого блока кода, необходимо 
вызвать Environment.TickCount непосредственно перед блоком и сразу же 
после последнего оператора блока и взять разность значений.  
В блоке кода, для которого измеряется время, не должно быть операций 
распределения памяти для массивов, инициализации элементов массивов и 
операций вывода данных на консоль. Блоки кода должны содержать только 
операции с элементами массива.  
Вычисленные значения времени выполнения операций для трех типов 
массивов, а также число строк nrow и столбцов ncolumn выводятся на консоль.
Вывод должен быть подписан, т.е. вывод должен содержать информацию о 
том, какому типу массива отвечает выведенное значение.

Education
---------
Определить тип Education - перечисление(enum) со значениями Specialist, 
Вachelor, SecondEducation.

Exam
----
Определить класс Exam, который имеет три открытых автореализуемых 
свойства, доступных для чтения и записи:
* свойство типа string, в котором хранится название предмета; 
* свойство типа int, в котором хранится оценка;
* свойство типа System.DateTime для даты экзамена.  

В классе Exam определить:
* конструктор с параметрами типа string, int и DateTime для инициализации 
всех свойств класса; 
* конструктор без параметров, инициализирующий все свойства класса 
некоторыми значениями по умолчанию;
* перегруженную(override) версию виртуального метода string ToString() для 
формирования строки со значениями всех свойств класса.

Student
-------
Определить класс Student, который имеет 
* закрытое поле типа Person, в котором хранятся данные студента;
* закрытое поле типа Education для информации о форме обучения;
* закрытое поле типа int для номера группы;
* закрытое поле типа Exam *+ для информации об экзаменах, которые сдал 
студент. 

В классе Student определить конструкторы:
* конструктор c параметрами типа Person, Education, int для инициализации 
соответствующих полей класса;
* конструктор без параметров, инициализирующий поля класса значениями 
по умолчанию.  

В классе Student определить свойства c методами get и set:
* свойство типа Person для доступа к полю с данными студента; 
* свойство типа Education для доступа к полю с формой обучения;
* свойство типа int для доступа к полю с номером группы; 
* свойство типа Exam *+ для доступа к полю со списком экзаменов.

В классе Student определить 
* свойство типа double ( только с методом get), в котором вычисляется 
средний балл как среднее значение оценок в списке сданных экзаменов;
* индексатор булевского типа (только с методом get) с одним параметром 
типа Education; значение индексатора равно true, если значение поля с 
формой обучения студента совпадает со значением индекса, и false в 
противном случае;
* метод void AddExams ( params Exam [] ) для добавления элементов в
список экзаменов;
* перегруженную версию виртуального метода string ToString() для 
формирования строки со значениями всех полей класса, включая список 
экзаменов;
* виртуальный метод string ToShortString(), который формирует строку со
значениями всех полей класса без списка экзаменов, но со значением 
среднего балла.

Program
-------
В методе Main()
1. Создать один объект типа Student, преобразовать данные в текстовый 
вид с помощью метода ToShortString() и вывести данные.
2. Вывести значения индексатора для значений индекса Education.Specialist, 
Education.Bachelor и Education.SecondEducation.
3. Присвоить значения всем определенным в типе Student свойствам, 
преобразовать данные в текстовый вид с помощью метода ToString() и 
вывести данные.
4. C помощью метода AddExams( params Exam*+ ) добавить элементы в 
список экзаменов и вывести данные объекта Student, используя метод 
ToString().
5. Сравнить время выполнения операций с элементами одномерного, 
двумерного прямоугольного и двумерного ступенчатого массивов с 
одинаковым числом элементов типа Exam.
