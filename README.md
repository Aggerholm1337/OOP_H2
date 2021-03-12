## OOP Design principper

#Høj kobling:
Høj kobling betyder f.eks. en klasse har brug for viden om hvordan en anden klasse er og en ændring i den anden klasse kan påvirke den første klasse. 
Så at forstå den første klasse skal man også forstå den anden klasse.

- Vores Bus, Truck, og PassengerCar er høj kobling, da ændringerne vi laver deri, påvirker vehicle klassen.

#Lav kobling:
For at få lav kobling skal vores moduler(Ansvarsområder) være 
uafghængige af hinanden, og ved ændringer i moduler og klasser, påvirke andet kode så lidt som muligt.

Lav kobling betyder at den første klasse ikke burde blive påvirket af ændringer i den anden klasse.

- Vores User modul og vores Vehicle Modul er lave koblinger, da ændringerne vi laver heri, ikke påvirke andre moudler i programmet, de er sepereret i ansvarsområder.

modsatte af lav kobling.
#Høj samhørighed:
Høj samhørighed er stort set det modsatte af lav kobling, vi vil gerne have sammenhæng i og mellem klasserne, men opdelt inden for hvert ansvarsområde.

Høj samhørighed betyder at f.eks. en klasse kun har at gøre med sit eget ansvarsområde, f.eks. vehicle og ikke vehicle samt user.

- Vores Vehicle klasse, er høj samhørighed, da de skaber sammenhængen mellem Bus, Truck, PassengerCar. Uden at påvirke Users eller andre moduler.
