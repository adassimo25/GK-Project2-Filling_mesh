# GK-Project2-Filling_mesh
<b>Filling mesh</b> to program do wypełniania siatki edytowalnych trójkątów oraz "zabawy światłem i obrazem" stworzony w ramach przedmiotu "Grafika komputerowa 1" na 5. semestrze studiów.

Użytkownik obsługuje program za pomocą myszki (wyjątkiem jest edytowanie parametrów rozmiaru siatki, kiedy odpowiednie liczby można wpisać za pomocą klawiatury).

W zakładce Menu na górnym pasku narzędzi dostępna jest jedynie opcja Exit - wyjście z programu.

Panel po lewej stronie okna aplikacji zawiera grupy opcji edycji obrazu, który znajduje się po prawej stronie.

<b>Mesh:</b>
- pole numeryczne <b>M</b> - wskazuje na liczbę trójkątów w poziome; M jest wartością całkowitą z przedziau <1, 25>; domyślna wartość M=5,
- pole numeryczne <b>N</b> - wskazuje na liczbę trójkątów w pionie; N jest wartością całkowitą z przedziau <1, 25>; domyślna wartość N=5,
- checkbox <b>visible</b> - określa, czy siatka trójkątów jest widoczna; siatkę można wyłączyć w każdym momencie, niezależnie od trybu odświeżania.

Oczywiście liczba trójkątów w siatce wynosi 2xMxN. Wszystkimi wierzchołkami trójkątów, poza skrajnymi leżącymi na "granicy" siatki, można poruszać. Jeżeli na obrazie działa animacja źródła światła, na czas poruszania wierzchołkiem jest ona wstrzymywana (pozwala to zachować jej płynność). Zakładamy, że użytkownik nie przesunie wierzchołka poza wielokąt, wewnątrz którego dany wierzchołek się znajduje (wierzchołek nie znajdzie się na którymś z sąsiadujących trójkątów, do których nie należy) - jest to niezbędne do poprawnego wypełniania oraz działania animacji. Niemożliwe jest również przesunięcie wierzchołka poza "granice" siatki.

<b>Factors:</b>
- <b>k<sub>s</sub></b> - współczynnik określający wpływ składowej zwierciadlanej modelu Lamberta na kolor wypełnienia; k<sub>s</sub> jest wartością z przedziału <0, 1> z dokładnością do trzeciego miejsca po przecinku; domyślna wartość k<sub>s</sub>=0,5,
- <b>k<sub>d</sub></b> - współczynnik określający wpływ składowej rozproszonej modelu Lamberta na kolor wypełnienia; k<sub>d</sub> jest wartością z przedziału <0, 1> z dokładnością do trzeciego miejsca po przecinku; domyślna wartość k<sub>d</sub>=0,75,
- <b>m</b> - współczynnik opisujący jak bardzo dany trójkąt jest zwierciadlany; m jest wartością całkowitą z przedziału <1, 100>; domyślna wartość m=25.

Podane współczynniki są jednakowe dla każdego trójkąta z siatki.

<b>Normal vector:</b>
- radiobutton <b>texture</b> - wektor normalny podawany w teksturze (NormalMap) dla całego "panelu"; N<sub>x</sub>=<-1,+1>, N<sub>y</sub>=<-1,+1>, N<sub>z</sub>=<0,+1>; po wyznaczeniu i przed zastosowaniem w modelu Lamberta musi on zostać znormalizowany; przycisk <b>Load</b> obok pozwala załadować NormalMap z systemu,
- radiobutton <b>constant</b> - wektor normalny stały i równy \[0,0,1\].

Domyślnie w aplikacji jest załadowana pewna tekstura.

<b>Light:</b>
- label <b>Color</b> - po kliknięciu pozwala wybrać kolor światła, którym oświetlony jest obraz; kolorem domyślnym jest kolor biały,
- Versor radiobutton <b>spiral</b> - wersor światła jest wyznaczany do punktu animowanego po spirali (właściwie po śrubie - wysokość źródła światła nad obiektem zmienia się liniowo w zależności od czasu) wokół ekranu,
- Versor radiobutton <b>constant</b> - wersor światła jest stały i równy \[0,0,1\].

Domyślnie wersor światła jest stały.

<b>Object color:</b>
- radiobutton <b>texture</b> - kolorem obiektu jest pewna tekstura, która może być wczytana z systemu przy użyciu przycisku <b>Load</b> znajdującego się obok,
- radiobutton <b>constant</b> - kolor obiektu jest stały i możliwy do określenia za pomocą kliknięcia na etykietę obok.

Domyślnie w aplikacji jest załadowana pewna tekstura. W przypadku zmiany koloru na stały, w tle nadal jest widoczna ostatnio używana tekstura.

<b>Filling:</b>
- radiobutton <b>precision</b> - dane koloru obiektu oraz wektory normalne są pobierane z tekstury w danym punkcie z uwzględnieniem światła; jest to opcja zaznaczona domyślnie, 
- radiobutton <b>iterpolation</b> - kolor obiektu jest wyznaczany tylko w wierzchołkach trójkątów, a następnie interpolowany do ich wnętrza.

Trójkąty w siatce są wypełniane algorytmem wypełniania wielokątów z sortowaniem kubełkowym krawędzi.

<b>Refreshing:</b>
- checkbox <b>dynamic</b> - w przypadku zaznaczenia tego pola każda zmiana powyższych parametrów jest natychmiastowa, ponieważ "odświeżenie" obiektu po prawej stronie następuje od razu, 
- przycisk <b>Refresh</b> - przycisk możliwy do kliknięcia tylko w przypadku niezaznaczenia pola <b>dynamic</b>; po kliknięciu następuje aktualizacja obiektu na podstawie zmienionych parametrów.

Domyślnie zmiany nie zachodzą dynamicznie.

<br /><b>Autor:</b><br /> Adam Ryl, student PW MiNI G3.
