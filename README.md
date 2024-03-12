# FilesOnline

Navrhn�te a vytvo�te datovou strukturu pro ukl�d�n� informac� o slo�k�ch ulo�en�ch do stromov� struktury - to znamen�, �e ka�d� slo�ka m��e obsahovat dal�� slo�ky.
Slo�ka m��e m�t p�esn� jednoho rodi�e. Pak vytvo�te aplikaci, kter� umo�n� touto strukturou proch�zet a zobrazovat seznam podslo�ek.

## Zad�n�

1. Vytvo�te datovou strukturu pro ukl�d�n� informac� o slo�k�ch ulo�en�ch do stromov� struktury. Jedin� datov� polo�ka je n�zev slo�ky. Jak se odk�ete na podlo�ky a rodi�e t�to slo�ky je na V�s. Kl��em k z�znamu o slo�ce by m�lo b�t vygenerovan� Guid.					
1. Zkonfigurujte Entity Framework tak, aby pracoval s datab�z� SQLite (*files.sqlite*)
1. P�eneste navr�enou strukturu do datab�ze
1. Naseedujte do datab�ze n�kolik z�znam� - ide�ln� ve t�ech �rovn�ch
1. Data vlo�te do datab�ze - tzv. seedov�n�
1. Modifikujte str�nku index.cshtml tak, aby se dok�zala p�ipojit k datab�zi
1. Na str�nce zobrazte seznam slo�ek (ko�enov�ch)
1. P�idejte mo�nost "rozbalit" obsah slo�ky (podslo�ky) tak, aby do�lo k na�ten� jen dat z t�to podslo�ky - pou�ijte tedy explicit loading
1. (Roz���en� zad�n�) P�idejte po�nost proch�zet strukturou sm�rem k podslo�k�m p�es odkazy

## Screenshoty

### Z�klad

![Z�kladn� str�nka](screenshots/basic/Bas1.png)

![Z�kladn� str�nka](screenshots/basic/Bas2.png)

![Z�kladn� str�nka](screenshots/basic/Bas3.png)

### Roz���en�

![Z�kladn� str�nka](screenshots/advanced/Adv1.png)

![Z�kladn� str�nka](screenshots/advanced/Adv2.png)

![Z�kladn� str�nka](screenshots/advanced/Adv3.png)

## N�pov�da

Vygenerov�n� kl��e Guid

    FolderId = Guid.NewGuid()

