# Резерв++

Name of project: Резерв++

Purpose: 
Слугує для зручної роботи з базою даних військовозобов'язаних. 
Створює можливість для керування військовозобов'язаними, виконує функціонал ТЦК та містить інформацію про кожного громадянина.

Users:
1. User 1: Звичайна людина, яку можна мобілізувати чи яка вже є мобілізованою. Може дізнатись інформацію про себе з БД. Може змінити окрему інформацію про себе.
2. User 2: Працівник ТЦК - має можливість видавати користувачу User 3 дозволи на мобілізацію громадян та передавати їх у військову частину. Може дізнатись інформацію про себе з БД. Може змінити окрему інформацію про себе.
3. User 3: Штабний офіцер - може робити запит до User 2 на поповнення бригади. Може дізнатись інформацію про себе з БД. Може змінити окрему інформацію про себе.

Entity:
1. abstract class User (поля: unsigned int age, string name, unsigned int docID, string medicalExaminationResult, string city, bool isСonscript, bool hasDeferment)
3. class TCK 
4. class Conscript extends User
5. class Officer extends User (поля: numberOfRequestedPeople, numberOfTransferredPeople, string placeOfMilitaryService)  
6. class TCKEmployee extends User 
7. database Reservepp

Program opportunities: 
Користувач може створити свій обліковий запис, система автоматично підтягне запис у базі даних та створить юзера відповідного типу. У застосунку користувач може використовувати відповідні йому можливості вказані у пункті Users. 

The UI will be developed on Windows Forms
