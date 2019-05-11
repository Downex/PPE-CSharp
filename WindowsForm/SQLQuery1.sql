CREATE TABLE Utilisateur (
	id int IDENTITY(1, 1) Primary key,
	login varchar(30) Not Null,
	password varchar(255) Not Null,
	prenom varchar(30) Not Null,
	nom varchar(30) Not Null,
	score int Not Null,
	rang varchar(60) Not Null,
	isAdmin int Not Null
)

CREATE TABLE Nom(
	id int IDENTITY(1, 1) Primary Key,
	singulier varchar(50) Not Null,
	pluriel varchar(50) Not Null,
	genre varchar(50) Not Null,

)

CREATE TABLE Pronom(
	id int IDENTITY(1, 1) Primary Key,
	singulier varchar(50) Not Null,
	pluriel int Not Null,
	genre varchar(50) Not Null,

)

CREATE TABLE Verbe(
	id int IDENTITY(1, 1) Primary Key,
	infinitf varchar(150) NOT NULL,

)

CREATE TABLE Conjugaison(
	id int IDENTITY(1, 1) Primary Key,
	temps varchar(150) Not Null,
	premierSing varchar(150) Not Null,
	deuxiemeSing varchar(150) Not Null,
	troisiemeSing varchar(150) Not Null,
	premierPlur varchar(150) Not Null,
	deuxiemePlur varchar(150) Not Null,
	troisiemePlur varchar(150) Not Null,
	idVerbe int Not Null,
	FOREIGN KEY (idVerbe) REFERENCES Verbe(id)
)

CREATE TABLE Adjectif(
	id int IDENTITY(1, 1) Primary Key,
	singMasculin varchar(150) Not Null,
	singFeminin varchar(150) Not Null,
	plurMasculin varchar(150) Not Null,
	plurFeminin varchar(150) Not Null

)

CREATE TABLE Phrase (
	id int IDENTITY(1,1) Primary key,
	idPronom int Not Null,
	idNom int Not Null,
	idVerbe int Not Null,
	idAdjectif int Not NUll,
	FOREIGN KEY (idPronom) REFERENCES Pronom(id),
	FOREIGN KEY (idNom) REFERENCES Nom(id),
	FOREIGN KEY (idVerbe) REFERENCES Verbe(id),
	FOREIGN KEY (idAdjectif) REFERENCES Adjectif(id)
)
