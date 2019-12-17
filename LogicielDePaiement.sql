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
 Ann�sSc varchar(10),
 date_InS date,
 Nom_Utl varchar(22),
 );
  create table Detaile
 (
 Matricule int constraint fk_Matricule foreign key references etudiant(Matricule),
 �ch_Fr MONEY,--1
 Nbr_Fr int,--2
 Base_Fr MONEY,--3
 Total_Fr MONEY,--4
 Solde_Fr MONEY,--5
 �ch_Fr_Np varchar(12),--6

 �ch_Sc MONEY,--7
 Nbr_Sc int,--7
 Base_Sc MONEY,--9
 Total_Sc MONEY,--10
 Solde_Sc MONEY,--11
 �ch_Sc_Np int,--12

  �ch_Tr decimal(11,2),--13
 Nbr_Tr int,--14
Base_Tr decimal(11,2),--15
 Total_Tr decimal(11,2),--16
 Solde_Tr decimal(11,2),--17
  �ch_Tr_Np int,--18

  �ch_Ps1 decimal(11,2),--19
 Nbr_Ps1 int,--20
 Base_Ps1 decimal(11,2),--21
 Total_Ps1 decimal(11,2),--22
 Solde_Ps1 decimal(11,2),--23
  �ch_Ps1_Np int,--24

  �ch_Ps2 decimal(11,2),--25
 Nbr_Ps2 int,--26
 Base_Ps2 decimal(11,2),--27
 Total_Ps2 decimal(11,2),--28
 Solde_Ps2 decimal(11,2),--29
  �ch_Ps2_Np int,--30

 �ch_Ps3 decimal(11,2),--31
 Nbr_Ps3 int,--32
 Base_Ps3 decimal(11,2),--33
 Total_Ps3 decimal(11,2),--34
 Solde_Ps3 decimal(11,2),--35
  �ch_Ps3_Np int,--36
 );
  select * from Detaile
  create Table Logiin
 (
 id_login int constraint pk_login primary key,
 userName Varchar(25),
 Passeword Varchar(20),
 );

 create Table Paiement
 (
 N_Re�u int constraint pk_Re�u primary key,
 Matricule int,
 Nom_Complet varchar(30),
 classe varchar(12),
 Ann�es_Sc varchar(10),
 date_Paiement date,
 Nom_Utl varchar(20),
 Detaile varchar(100),--7
 Esp�ces money,--8
 date_Vers_Esp�ces date,
 ch�que money,--10
 N_ch�que varchar(25),
 date_�ch_ch�q date,
 date_Remise_ch�q date,--13
 Bnq_Remise_ch�q varchar(25),
 sort_Ch�que varchar(10),
 date_Credit_ch�q date,--16
 Traite money,--17
 N_Traite varchar(25),
 date_�ch_Trt date,
 date_Remise_Trt date,--20
 Bnq_Remise_Trt varchar(25),
 sort_Traite varchar(10),
 date_Credit_Trt date,--23
 Virement money,--24
 date_Virement date,
 Bnq_Remise_Vrm varchar(25),
 TotalPay� money,
 );

 create table CompteBnq
 (
 Compte varchar(40),
 );
  create table ActivatorCode
 (
 ActivatorCode varchar(100),
 id int constraint pk_idActivator primary key,
 );



