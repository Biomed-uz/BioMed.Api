USE CentreMedDatabase;

-------------------------------Patient----------------------

INSERT INTO Patient(First_Name,Last_Name,Middle_Name,PhoneNumber,Email,Gender)
VALUES
('John','Jons','Jerry','+998215546987','johnjons@gmail.com','Male'),
('Jack','Wilshere','Wyatt','+998564792145','Jack@gmail.com','Male'),
('James','Rodriguez','Truett','+998651234567','James@gmail.com','Male'),
('Luka','Jovic','Jerry','+998215050221','Jovic@gmail.com','Male'),
('Tomas','Muller','Truett','+998204562456','Tomas@gmail.com','Male'),
('Patrick','Kluivert','Wyatt','+9985003020','Patrick@gmail.com','Male'),
('Jude','Bellingem','Jerry','+998215546987','Jude@gmail.com','Male'),
('Jamal','Musiala','Truett','+998901238999','Jamal@gmail.com','Male'),
('Frank','Lampard','Jerry','+998257074565','Frank@gmail.com','Male'),
('Arjen','Robben','Truett','+998215545487','Arjen@gmail.com','Male'),
('Leroy','Sane','Wyatt','+998215546985','Leroy@gmail.com','Male'),
('Harry','Kane','Jerry','+998215704987','Harry@gmail.com','Male'),
('Lucas','Hernandez','Jerry','+998215540087','Lucas@gmail.com','Male'),
('Dayot','Upamecano','Truett','+998266546901','Dayot@gmail.com','Male'),
('Alphonso','Davies','Jerry','+998215889633','Alphonso@gmail.com','Male'),
('Mathis','Delight','Truett','+998215546987','Mathis@gmail.com','Male'),
('Karim','Benzema','Wyatt','+99885698745','Karim@gmail.com','Male'),
('Cristiano','Ronaldo','Jerry','+998215004121','Cristiano@gmail.com','Male'),
('Leo','Messi','Jerry','+998885546987','LeoMessi@gmail.com','Male'),
('Erling','Holland','Truett','+998775546900','Erling@gmail.com','Male'),
('Marko','Assensio','Jerry','+998105546087','Marko@gmail.com','Male'),
('Junior','Neymar','Jerry','+998215546987','Junior@gmail.com','Male'),
('Diaz','Brahm','Wyatt','+998005540980','Diaz@gmail.com','Male'),
('Alves','Dani','Jerry','+998015546987','Alves@gmail.com','Male'),
('Frank','De Jong','Jerry','+998200546987','Frank@gmail.com','Male'),
('Darvin','Nunez','Wyattv','+99801554007','Darvin@gmail.com','Male'),
('Martin','Edegor','Jerry','+99821050980','Martin@gmail.com','Male');

--------Test----------
/*SELECT * FROM Patient;*/

-------------------------------Category----------

INSERT INTO Category(Name)
VALUES
('Blood'),
('Cancer and Neoplasms'),
('Cardiovascular'),
('Congenital disorders'),
('Ear'),
('Eye'),
('Infection'),
('Injuries and accidents'),
('Neurological'),
('Respiratory');

--------Test----------
/*SELECT * FROM Category;*/

--------------------------------Department----------

INSERT INTO Department(Department_Name)
VALUES
('Admissions'),
('Accident and emergency (A&E)'),
('Neurology'),
('Cardiology'),
('Critical Care'),
('General Services'),
('Gynecology'),
('Information Management');

--------Test----------
/*SELECT * FROM Department;*/

---------------------------------Doctor----------

INSERT INTO Doctor(Full_Name,Phone_Number,Email,Price_Per_Visit)
VALUES
('Akira Carey','+995471445', 'akira@gmail.com', 100),
('Kaleb Howell','+995400245', 'kaleb@gmail.com', 80),
('Hezekiah Shannon','+995881345', 'shannon@gmail.com', 150),
('Elisa Chan','+995871045', 'elisa@gmail.com', 120),
('Marquis Sexton','+995491945', 'marquis@gmail.com', 100),
('Carolyn Pugh','+995491441', 'carolyn@gmail.com', 50),
('Kailee Hansen','+995411448', 'kailee@gmail.com', 80),
('Rosemary Walls','+995071447', 'rosemary@gmail.com', 150),
('Abdullah Burns','+995873640', 'abdullah@gmail.com', 130),
('Noe Rowland','+995771005', 'noerowland@gmail.com', 100);

--------Test----------
/*SELECT * FROM Doctor;*/

--------------------------------Doctor Department----------

INSERT INTO Doctor_Department(Doctor_Id, Department_Id)
VALUES
(1,4),
(1,7),
(2,4),
(2,3),
(2,7),
(3,1),
(4,6),
(5,2),
(5,6),
(6,5),
(7,5),
(8,4),
(9,3),
(10,7);

--------Test----------
/*SELECT * FROM Doctor_Department;*/

-----------------------------------Doctor Category----------

INSERT INTO Doctor_Category(Doctor_Id, Category_Id)
VALUES
(1,10),
(1,7),
(2,8),
(2,3),
(2,7),
(3,1),
(4,6),
(5,2),
(5,6),
(6,5),
(7,9),
(8,4),
(9,3),
(10,7),
(1,4),
(1,5),
(2,3),
(2,9),
(2,3),
(3,8),
(4,6),
(5,2),
(5,6),
(6,5),
(7,9),
(8,4),
(9,10),
(10,7);

--------Test----------
/*SELECT * FROM Doctor_Category;*/

------------------------------------Visit----------

INSERT INTO Visit(Patient_Id, Doctor_Id, Visit_Date, Total_Price, Prescriptions)
VALUES
(1,10,GETDATE(),450,'Antibiotics are medicines prescribed by your doctor to treat infections. Overuse can lead to antibiotic resistance.'),
(9,1,GETDATE(),400,'Antibiotics are medicines prescribed by your doctor to treat infections. Overuse can lead to antibiotic resistance.'),
(2,6,GETDATE(),150,'Antibiotics are medicines prescribed by your doctor to treat infections. Overuse can lead to antibiotic resistance.'),
(8,1,GETDATE(),300,'Antibiotics are medicines prescribed by your doctor to treat infections. Overuse can lead to antibiotic resistance.'),
(3,3,GETDATE(),500,'Antibiotics are medicines prescribed by your doctor to treat infections. Overuse can lead to antibiotic resistance.'),
(7,2,GETDATE(),420,'Antibiotics are medicines prescribed by your doctor to treat infections. Overuse can lead to antibiotic resistance.'),
(4,7,GETDATE(),480,'Antibiotics are medicines prescribed by your doctor to treat infections. Overuse can lead to antibiotic resistance.'),
(6,10,GETDATE(),450,'Antibiotics are medicines prescribed by your doctor to treat infections. Overuse can lead to antibiotic resistance.'),
(5,5,GETDATE(),440,'Antibiotics are medicines prescribed by your doctor to treat infections. Overuse can lead to antibiotic resistance.'),
(11,4,GETDATE(),750,'Antibiotics are medicines prescribed by your doctor to treat infections. Overuse can lead to antibiotic resistance.'),
(12,9,GETDATE(),600,'Antibiotics are medicines prescribed by your doctor to treat infections. Overuse can lead to antibiotic resistance.'),
(13,7,GETDATE(),110,'Antibiotics are medicines prescribed by your doctor to treat infections. Overuse can lead to antibiotic resistance.'),
(14,8,GETDATE(),600,'Antibiotics are medicines prescribed by your doctor to treat infections. Overuse can lead to antibiotic resistance.'),
(15,5,GETDATE(),900,'Antibiotics are medicines prescribed by your doctor to treat infections. Overuse can lead to antibiotic resistance.'),
(16,6,GETDATE(),1000,'Antibiotics are medicines prescribed by your doctor to treat infections. Overuse can lead to antibiotic resistance.'),
(17,2,GETDATE(),550,'Antibiotics are medicines prescribed by your doctor to treat infections. Overuse can lead to antibiotic resistance.'),
(19,1,GETDATE(),400,'Antibiotics are medicines prescribed by your doctor to treat infections. Overuse can lead to antibiotic resistance.'),
(18,3,GETDATE(),450,'Antibiotics are medicines prescribed by your doctor to treat infections. Overuse can lead to antibiotic resistance.'),
(20,4,GETDATE(),300,'Antibiotics are medicines prescribed by your doctor to treat infections. Overuse can lead to antibiotic resistance.'),
(21,10,GETDATE(),250,'Antibiotics are medicines prescribed by your doctor to treat infections. Overuse can lead to antibiotic resistance.'),
(1,6,GETDATE(),200,'Antibiotics are medicines prescribed by your doctor to treat infections. Overuse can lead to antibiotic resistance.'),
(2,8,GETDATE(),220,'Antibiotics are medicines prescribed by your doctor to treat infections. Overuse can lead to antibiotic resistance.'),
(3,9,GETDATE(),350,'Antibiotics are medicines prescribed by your doctor to treat infections. Overuse can lead to antibiotic resistance.'),
(15,4,GETDATE(),350,'Antibiotics are medicines prescribed by your doctor to treat infections. Overuse can lead to antibiotic resistance.'),
(10,5,GETDATE(),690,'Antibiotics are medicines prescribed by your doctor to treat infections. Overuse can lead to antibiotic resistance.'),
(5,7,GETDATE(),870,'Antibiotics are medicines prescribed by your doctor to treat infections. Overuse can lead to antibiotic resistance.'),
(6,6,GETDATE(),950,'Antibiotics are medicines prescribed by your doctor to treat infections. Overuse can lead to antibiotic resistance.'),
(9,5,GETDATE(),660,'Antibiotics are medicines prescribed by your doctor to treat infections. Overuse can lead to antibiotic resistance.'),
(8,9,GETDATE(),190,'Antibiotics are medicines prescribed by your doctor to treat infections. Overuse can lead to antibiotic resistance.'),
(1,8,GETDATE(),460,'Antibiotics are medicines prescribed by your doctor to treat infections. Overuse can lead to antibiotic resistance.');

--------Test----------
/*SELECT * FROM Visit;*/

------------------------------------Payment----------

INSERT INTO Payment(Visit_Id, Amount, Payment_Date)
VALUES
(1,1000,GETDATE()),
(2,1200,GETDATE()),
(3,1300,GETDATE()),
(4,1400,GETDATE()),
(5,1500,GETDATE()),
(6,1900,GETDATE()),
(7,1500,GETDATE()),
(8,1200,GETDATE()),
(9,1300,GETDATE()),
(10,11000,GETDATE()),
(11,1600,GETDATE()),
(12,1500,GETDATE()),
(13,1400,GETDATE()),
(14,1900,GETDATE()),
(15,1800,GETDATE()),
(2,10000,GETDATE()),
(3,3000,GETDATE()),
(4,4000,GETDATE()),
(5,5000,GETDATE()),
(6,6000,GETDATE()),
(7,1000,GETDATE()),
(8,2000,GETDATE()),
(9,2000,GETDATE()),
(10,1000,GETDATE());

--------Test----------
/*SELECT * FROM Payment;*/

--------------------------------Disease category----------

INSERT INTO Disease_Category(Disease_Category_Name)
VALUES
('Infectious diseases'),
('Deficiency diseases'),
('Hereditary diseases'),
('Physiological diseases'),
('Epidemiological diseases');

--------Test----------
/*SELECT * FROM Disease_Category;*/

----------------------------------------Disease----------

INSERT INTO Disease(Disease_Name,Disease_Category_Id)
VALUES
('Hepatitis A',1),
('Measles',5),
('Glaucoma',4),
('Vitamin K Deficiency',2),
('Xerophthalmia, and Iron Deficiency',2),
('Asthma',4),
('Hepatitis C',1),
('COVID-19',5),
('Ankylosing spondylitis',2),
('Hepatitis B',1);

--------Test----------
/*SELECT * FROM Disease;*/

-----------------------------------------Test type----------

INSERT INTO Test_Type(Name)
VALUES
('Cancer blood testing'),
('Blood count'),
('CT scan'),
('Liver function tests'),
('Thyroid tests'),
('Tomography'),
('Blood differential'),
('Biopsy'),
('Cholesterol levels');

--------Test----------
/*SELECT * FROM Test_Type;*/

---------------------------------------laboratory result----------

INSERT INTO Laboratory_Result(Test_Type_Id,Result,Date)
VALUES
(3,'Negative',GETDATE()),
(2,'Negative',GETDATE()),
(7,'Positive',GETDATE()),
(4,'Positive',GETDATE()),
(1,'Negative',GETDATE()),
(4,'Positive',GETDATE()),
(5,'Negative',GETDATE()),
(6,'Positive',GETDATE()),
(6,'Positive',GETDATE()),
(3,'Negative',GETDATE());

--------Test----------
/*SELECT * FROM Laboratory_Result;*/

------------------------------------------Treatment----------

INSERT INTO Treatment(Visit_Id,Disease_Id,Laboratory_Result_Id,Prescriptions)
VALUES
(1,4,2,'Numerous medications are available for the acute treatment of migraine in adults, and some have now been approved for use in children and adolescents in the ambulatory setting. A systematic review of acute treatment of migraine medication trials in children and adolescents will help clinicians make evidence-informed management choices.'),
(2,2,1,'Numerous medications are available for the acute treatment of migraine in adults, and some have now been approved for use in children and adolescents in the ambulatory setting. A systematic review of acute treatment of migraine medication trials in children and adolescents will help clinicians make evidence-informed management choices.'),
(3,6,3,'Numerous medications are available for the acute treatment of migraine in adults, and some have now been approved for use in children and adolescents in the ambulatory setting. A systematic review of acute treatment of migraine medication trials in children and adolescents will help clinicians make evidence-informed management choices.'),
(4,7,4,'Numerous medications are available for the acute treatment of migraine in adults, and some have now been approved for use in children and adolescents in the ambulatory setting. A systematic review of acute treatment of migraine medication trials in children and adolescents will help clinicians make evidence-informed management choices.'),
(5,3,5,'Numerous medications are available for the acute treatment of migraine in adults, and some have now been approved for use in children and adolescents in the ambulatory setting. A systematic review of acute treatment of migraine medication trials in children and adolescents will help clinicians make evidence-informed management choices.'),
(6,5,7,'Numerous medications are available for the acute treatment of migraine in adults, and some have now been approved for use in children and adolescents in the ambulatory setting. A systematic review of acute treatment of migraine medication trials in children and adolescents will help clinicians make evidence-informed management choices.'),
(7,4,4,'Numerous medications are available for the acute treatment of migraine in adults, and some have now been approved for use in children and adolescents in the ambulatory setting. A systematic review of acute treatment of migraine medication trials in children and adolescents will help clinicians make evidence-informed management choices.'),
(8,1,3,'Numerous medications are available for the acute treatment of migraine in adults, and some have now been approved for use in children and adolescents in the ambulatory setting. A systematic review of acute treatment of migraine medication trials in children and adolescents will help clinicians make evidence-informed management choices.'),
(9,1,1,'Numerous medications are available for the acute treatment of migraine in adults, and some have now been approved for use in children and adolescents in the ambulatory setting. A systematic review of acute treatment of migraine medication trials in children and adolescents will help clinicians make evidence-informed management choices.'),
(10,8,2,'Numerous medications are available for the acute treatment of migraine in adults, and some have now been approved for use in children and adolescents in the ambulatory setting. A systematic review of acute treatment of migraine medication trials in children and adolescents will help clinicians make evidence-informed management choices.'),
(11,5,1,'Numerous medications are available for the acute treatment of migraine in adults, and some have now been approved for use in children and adolescents in the ambulatory setting. A systematic review of acute treatment of migraine medication trials in children and adolescents will help clinicians make evidence-informed management choices.'),
(12,3,3,'Numerous medications are available for the acute treatment of migraine in adults, and some have now been approved for use in children and adolescents in the ambulatory setting. A systematic review of acute treatment of migraine medication trials in children and adolescents will help clinicians make evidence-informed management choices.'),
(8,6,6,'Numerous medications are available for the acute treatment of migraine in adults, and some have now been approved for use in children and adolescents in the ambulatory setting. A systematic review of acute treatment of migraine medication trials in children and adolescents will help clinicians make evidence-informed management choices.'),
(9,6,4,'Numerous medications are available for the acute treatment of migraine in adults, and some have now been approved for use in children and adolescents in the ambulatory setting. A systematic review of acute treatment of migraine medication trials in children and adolescents will help clinicians make evidence-informed management choices.'),
(5,2,7,'Numerous medications are available for the acute treatment of migraine in adults, and some have now been approved for use in children and adolescents in the ambulatory setting. A systematic review of acute treatment of migraine medication trials in children and adolescents will help clinicians make evidence-informed management choices.');
       
--------Test----------
/*SELECT * FROM Treatment;*/