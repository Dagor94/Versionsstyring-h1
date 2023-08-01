# Versionsstyring-h1
*Lavet af Johannes og Philip*

Dette Repository er lavet med formål at lære om versionsstyring, herunder Branching, konfilkthåndtering, Merge og Revert, m.m. Vi skal også lave en strategi for hvordan vil vi  sikre vores data under uddannelse




### Strategi for data / programmer under Datatekniker uddannelsen:
Fil-stuktur
- Folders skal opdeles og differences med navn og/eller versionsID. Så det er nemt at overskue og identificere hvad leder efter.

Ét repo eller mange
- Afhængig af projektets størrelse eller emne vurderes det om det skal have sit eget repo eller det skal lægges ind i et repo med flere projekter.
  Eksempelvis kan man have et repository til en vejr Applikation og et seperat repository til en masse små opgaver som ikke kraver deres eget repo.
Adgangskontrol

- Umiddelbart er der tillid til hinaden så der er ikke behov for at låse hverken main eller side branches.
  Dog er det fordelagtigt at kun én arbejder en den enkelte branch givet det er muligt for at udgå konflikter samt at minimere tid der skal bruges på pull requests.

Hvordan skal i holde struktur i filer?
- Navngivning af filer
  - Filer skal opdeles og differences med navn og/eller versionsID. Så det er nemt at overskue og identificere hvad leder efter.
- Kommantar i code
  - Kommentare skal bruges til at simplificere større stykker kode eller metoder for at gøre koden generel mere læsevenlig -
    dog skal den ikke bruges til at beskrive hvert stykke kode det det vil være forstyrrende og modarbejde kommentarens formål.
- Navngivning af variabler og metoder
  - Både variabler og metoder er det hensigtsmæssigt at give konkrete, relevante og beskrivende navne, så en programmør og en selv samt ens kolleger ikke er i tvivl om formålet med variablen eller metoden.

Hvad skal der beskrives i commit beskeder?
- Der skal beskrives den overordnede ændring, altså hvad er blevet fjernet eller tilføjet. Hvis man har fjernet noget, så vil en begrundelse være krævet. Hvis man har tilføjet en funktion eller ligne så beskrives det hvad funktionen gør og generel info om den.

Hvad er grunden til at i vil branche?
- For at undgår for mange konflikter og at skulle pull hver dag og lave eventuel konfilkthåndtering hver dag.

Hvordan vil i lave code review?
- Når der skal merges eller tilføjes større stykekr kode skal det kigges igennem af flere personer i gruppen for at sikre at alle forstår det samt at det bliver sat ind korrekt i det større billede.
