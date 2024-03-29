# MyApi

Autor: Krzysztof Maciejończyk

Opis programu:

Program służy do zbierania danych na temat informacji podatkowych firm mieszczących się w Unii Europejskiej (system VIES). Są one pobierane poprzez zewnętrzne API po podaniu dwóch parametrów wejściowych w pola tekstowe Country (numer kraju) i VAT (numer VAT). Użytkownik ma do dyspozycji GUI, na którym umieszczono szereg funkcji, umożliwiającym mu zarządzanie danymi w bazie danych. Cały program składa się z bazy danych znajduącej się w pliku **WIES .db**, klasy przechowującej informacje o jednym rekordzie **WIES.cs**, klasy tworzącej bazę danych **WIESDB.CS** oraz 4 Windows Forms:

**-MainGUI.cs** - główne okno programu, z którego użytkownik zarządza wszelkimi operacjami.
**-OrderBy.cs** - okno wyświetlające się w celu uszeregowania rekordów w bazie danych według podanego wzoru.
**-Remove.cs** - okno występujące po wciśnięciu przycisku Remove, które pozwala usunąć wybrany rekord z bazy daych po wpisaniu ID rekordu.
**-Statistics.cs** - okno zawierające statystyki na temat zebranych danych w bazie.

Okno główne programu (Main_GUI) zawiera następujące pola i przyciski:

**-pole "Downloaded company's basic information"** pokazuje informacje o firmie. _Uwaga! Samo wciśnięcie przycisku "Download" nie wpisuje firmy do bazy danych, a jedynie przedstawia wstępne informacje o firmie z podanym kodem kraju i VAT_

**-pole "Current Database"** przedstawia obecny stan bazy danych, na której można wykonywać różne operacje.

**-pole "Country"** parametr wejściowy w postaci kodu kraju.

**-pole "VAT"** parametr wejściowy w postaci numeru VAT.

**-przycisk "Add"** dodaje pobrane informacje firmy do bazy danych.

**-przycisk "Download"** pokazuje wszelkie informacje pobrane przy pomocy API w formacie JSON w polu "Downloaded company's basic information".

**-przycisk "Display All"** wyświetla aktualną bazę danych w polu "Current Database".

**-przycisk "Order By"** szereguje bazę danych względem wybranego wzorca. Otwierane jest nowe okno, gdzie użytkownik ma do dyspozycji opcje szeregowania względem nazwy, adresu, numeru VAT, daty dodania do bazy lub walidacji firmy.

**-przycisk "Remove"** usuwa wybrany rekord z bazy po podaniu odpowiedniego ID wpisu.

**-przycisk "Remove All"** usuwa wszystkie rekordy z bazy.

**-przycisk "Statistics"** otwiera nowe okno z dwoma statystykami. Pierwsza stastystyka ukazuje liczbę zarejestrowanych firm w poszczególnych miastach. Druga zaś przedstawia ilość wpisów do bazy danych w poszczególnych dniach.

W programie zastosowano wszelkie procedury uodporniające program na niepożądane działanie użytkownika, jak wpisanie złego formatu do pól tekstowych, zapisu duplikatu do bazy danych czy usunięcie nieistniejącego rekordu.

Poniżej umieszczono zrzuty ekranu poszczególnych funkcji i okienek programu:

