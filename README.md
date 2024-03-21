# gamf_gameDev_prac_04

1. Feladat: Fal építése

	- 9 hosszúságú falat kell építeni Instantiate segítségével, 9 után 1 egységgel feljebb kell lerakni 9 téglát, aztán megint 9-et egy egységgel feljebb. Összesen 4 sort kell egymásra tenni. (GameObject brickClone = Instantiate("brick"), majd brickClone.transform.position = new Vector3( koordinata, koordinata, 0 )

	- A Start föggvénybe kell beleírni egy egymásba ágyazott for ciklust, de nem a tégla scriptjébe, mert minden instantiate másolja a scriptet is, tehát végtelen ciklust csinálnánk.

	- Kell egy empty gameObject, az legyen a neve, hogy: wallBuilder, aminek a scriptjén belül a Start()-ba kell írni

	- Készítünk egy bric prefabot, amin van egy boxCollider2D, majd az eredetit kitoroljuk

	- Ezután a wallbuilder empty script-re rákattintunk, majd hozzáadjuk a brick prefabot, ehhez: "public GameObject brickPrototype;"

	- Meg kell tervezni a pályán, hogy hol kezdődjön a sor, tehát az első tégla pivot pontjának értéket kell adni.

2. Feladat: Pálya beázárás

	- Húzzunk be egy slidert, amit a pálya közepére teszünk, majd oldalra és felülre kell építeni egy falat, hogy bezárjuk a pályát, rakjunk rá boxCollidert

	- Írjuk meg a scriptet, amivel a slidert tudjuk mozgatni: "if (Input.GetKey(KeyCode.A)) { transform.Translate(speed * (Vector3.left * Time.deltaTime)); }"

	- Állítsuk be, hogy a slider ütközzön az oldalfalakkal, egyszeruen megnezzuk a palyan a szelsoertek "Position" értékeit, majd beállítjuk hogy a transfor.position.x ne legyen nagyobb és kisebb ezeknél

3. Feladat: Labda létrehozása

	- Behúzzuk a labdát, ohzzáadjuk a RigidBody-t, és a CicrcleCollider-t. A Gravity Scla értékét 0-ra vesszük, majd adunk neki egy kezdő sebességet egy scripttel.

	- Assets/jobbklikk/create/2d/physics material 2d, majd bounciness 1

	- Hozzunk létre egy scriptet a bricknek, és érjük el, hogy amikor a labdával collideol 3-szor, akkor destroyolja a téglát.
	- Hozzunk létre kettő Sprite változót, amiknek nem adunk értéket, majd a prefabra kattintva adjuk hozzá a spriteokhoz a repedt téglák képét.