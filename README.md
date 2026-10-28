# README - Dziennik Treningów 💪

## Opis
Aplikacja **Dziennik Treningów** to proste narzędzie do śledzenia i zarządzania treningami.
Umożliwia użytkownikom rejestrowanie sesji treningowych, monitorowanie postępów oraz przeglądanie statystyk.

## Obecnie
Istnieją widoki takie jak:
- **Strona główna** - przycisk rozpoczęcia nowego treningu oraz bloki informacyjne
- **Historia treningów** - lista wszystkich treningów
- **Sesja treningu** - dodawanie ćwiczeń w trakcie treningu i zamykanie sesji
- **Statystyki** - podsumowanie twoich treningów
- **Informacje** - informacje o autorze i przyciski do historii treningów i statystyk

## Model danych
Trening reprezentuje klasa `Training`, a pojedyncze ćwiczenie klasa `Exercise` (relacja jeden trening → wiele ćwiczeń).

### Training
|Właściwość|Typ|Opis|
|---|---|---|
|Date|DateTime|data treningu|
|TrainingName|string|nazwa treningu, np. „Push”|
|AdditionalText|string|dodatkowy opis|
|Duration|TimeSpan|czas trwania treningu|
|Exercises|ObservableCollection&lt;Exercise&gt;|ćwiczenia wykonane w treningu|

### Exercise
|Właściwość|Typ|Opis|
|---|---|---|
|Number|int|kolejny numer ćwiczenia w treningu|
|ExerciseName|string|nazwa ćwiczenia, np. „Pompki”|
|Series|int|liczba serii|
|Reps|int|liczba powtórzeń|
|Weight|double|obciążenie w kilogramach|

## Rozbudowa
Aplikacja będzie mieć funkcje takie jak:
- **Zdjęcia** progresu
- Edycja i usuwanie treningów (CRUD)
- **Statystyki** postępów w czasie
- Szczegóły treningu po dotknięciu wiersza w historii

## Kolorystyka
Aplikacja posiada zarówno **tryb jasny jak i ciemny**.

### Tła i powierzchnie

|Motyw|Klucz w XAML|HEX|Zastosowanie|
|---|---|---|---|
|Jasny|`Primary`|#fafafa|powierzchnia strony|
|Jasny|`Secondary`|#f4f4f5|karta / panel|
|Jasny|`Tertiary`|#e4e4e7|-|
|Ciemny|`PrimaryDark`|#18181b|powierzchnia strony|
|Ciemny|`SecondaryDark`|#27272a|karta / panel|
|Ciemny|`TertiaryDark`|#3f3f46|-|

### Tekst

|Motyw|Klucz w XAML|HEX|
|---|---|---|
|Jasny|`PrimaryDarkText`|#18181b|
|Jasny|`SecondaryLightText`|#52525b|
|Ciemny|`PrimaryLightText`|#fafafa|
|Ciemny|`SecondaryDarkText`|#a1a1aa|

### Akcent

|Motyw|Klucz w XAML|HEX|
|---|---|---|
|Jasny|`AccentLight`|#4f46e5|
|Ciemny|`AccentDark`|#a5b4fc|
|Jasny|`Danger`|#dc2626|
|Ciemny|`DangerDark`|#f87171|
|Jasny|`Success`|#10b981|
|Ciemny|`SuccessDark`|#34d399|

## Autor
Autorem projektu jest Igor Wróblewski
