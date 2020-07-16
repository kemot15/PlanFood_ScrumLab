# Plan Food - ScrumLab

## Rozwiązanie, którego oczekuje klient ma zawierać:

- landing page, który zachęca do korzystania z aplikacji, wyświetlający - podstawowe informacje o projekcie,
- aplikacja przeglądarkowa, która umożliwia: 

     - rejestrację, 
     - logowanie,
     - dodawanie, modyfikowanie i usuwanie przepisów, 
     - wyświetlanie listy przepisów, 
     - tworzenie, wyświetlanie i modyfikowanie harmonogramu żywienia,
     - przeglądanie oraz blokowanie użytkowników przez administratora,
     - zarządzanie listą posiłków dla zalogowanego użytkownika.

## Ograniczenia projektowe

### Technologie - Do wykonania tego projektu użyto:

- ASP.NET Core MVC z ASP.NET Core Identity,
- warstwy dostępu do danych w postaci ORMappera EntityFramework Core,
- bazy danych MS SQL,
- gotowego szablonu html.

### W projekcie wykonano:

- DependencyInjection, aby nie tworzyć ręcznie instancji obiektów. Użyto interfejsów, które są wstrzykiwane w formie konkretnych implementacji,
- serwisy zawierające logikę biznesową, z których korzystają kontrolery,
- migracje bazy danych po dodaniu/modyfikacji/usunięciu modelu,
- walidację formularzy,
- zabezpieczenia w kontrolerach i akcjach, aby niezalogowany użytkownik nie mógł wejść do dowolnego miejsca w aplikacji oraz sprawdzać uprawnienia (np. przynależność do roli),
- modele widoków (ViewModel), aby nie operować w widoku na modelu bazodanowym.

