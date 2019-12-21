create Database LogicielDePaiement
use LogicielDePaiement

create Table factureN (id int);
 create Table etudiant
 (
 Matricule int constraint pk_etud primary key,
 Nom varchar(14),
 Prenom varchar(20),
 date_Nc date,
 sexe varchar(2),
 Mobile_Pr varchar(17),
 classe varchar(22),
 AnnésSc varchar(10),
 date_InS date,
 Nom_Utl varchar(22),
 );
 Select * from Detaile
  create table Detaile
 (
 Matricule int constraint fk_Matricule foreign key references etudiant(Matricule),
 éch_Fr  decimal(11,2),--1
 Nbr_Fr int,--2
 Base_Fr  decimal(11,2),--3
 Total_Fr  decimal(11,2),--4
 Solde_Fr  decimal(11,2),--5
 éch_Fr_Np varchar(12),--6

 éch_Sc  decimal(11,2),--7
 Nbr_Sc int,--7
 Base_Sc  decimal(11,2),--9
 Total_Sc  decimal(11,2),--10
 Solde_Sc  decimal(11,2),--11
 éch_Sc_Np int,--12

  éch_Tr decimal(11,2),--13
 Nbr_Tr int,--14
Base_Tr decimal(11,2),--15
 Total_Tr decimal(11,2),--16
 Solde_Tr decimal(11,2),--17
  éch_Tr_Np int,--18

  éch_Ps1 decimal(11,2),--19
 Nbr_Ps1 int,--20
 Base_Ps1 decimal(11,2),--21
 Total_Ps1 decimal(11,2),--22
 Solde_Ps1 decimal(11,2),--23
 éch_Ps1_Np int,--24

 éch_Ps2 decimal(11,2),--25
 Nbr_Ps2 int,--26
 Base_Ps2 decimal(11,2),--27
 Total_Ps2 decimal(11,2),--28
 Solde_Ps2 decimal(11,2),--29
 éch_Ps2_Np int,--30

 éch_Ps3 decimal(11,2),--31
 Nbr_Ps3 int,--32
 Base_Ps3 decimal(11,2),--33
 Total_Ps3 decimal(11,2),--34
 Solde_Ps3 decimal(11,2),--35
 éch_Ps3_Np int,--36
 );
  select * from Detaile
  create Table Logiin
 (
 userName Varchar(25),
 Passeword Varchar(20),
 );
 insert into Logiin 
 values ('khamkhami','123')
 select * from Logiin

 create Table Paiement
 (
 N_Reçu int constraint pk_Reçu primary key,--0
 Matricule int,--1
 Nom_Complet varchar(30),--2
 classe varchar(12),--3
 Années_Sc varchar(10),--4
 date_Paiement date,--5
 Nom_Utl varchar(20),--6
 Detaile varchar(100),--7
 Espèces decimal(11,2),--8
 date_Vers_Espèces date,--9
 chèque  decimal(11,2),--10
 N_chèque varchar(25),--11
 date_éch_chèq date,--12
 date_Remise_chèq date,--13
 Bnq_Remise_chèq varchar(25),--14
 sort_Chèque varchar(10),--15
 date_Credit_chèq date,--16
 Traite  decimal(11,2),--17
 N_Traite varchar(25),--18
 date_éch_Trt date,--19
 date_Remise_Trt date,--20
 Bnq_Remise_Trt varchar(25),--21
 sort_Traite varchar(10),--22
 date_Credit_Trt date,--23
 Virement  decimal(11,2),--24
 date_Virement date,--25
 Bnq_Remise_Vrm varchar(25),--26
 TotalPayé  decimal(11,2),--27
 );
 select * from Detaile
 create table CompteBnq
 (
 Compte varchar(40),
 );



