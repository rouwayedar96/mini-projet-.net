create table client
(
    NumCleint int(50) auto_increment
        primary key,
    Nom       varchar(50) not null,
    Rue       varchar(50) not null,
    Ville     varchar(50) not null,
    CP        int(50)     not null,
    Tel       int(50)     not null
)
    engine = InnoDB;

INSERT INTO commande.client (NumCleint, Nom, Rue, Ville, CP, Tel) VALUES (1, 'Jean', '43', 'Tunis', 445, 26772243);
INSERT INTO commande.client (NumCleint, Nom, Rue, Ville, CP, Tel) VALUES (2, 'Paul', '48755', 'Sfax', 55, 21447885);
INSERT INTO commande.client (NumCleint, Nom, Rue, Ville, CP, Tel) VALUES (3, 'Jean 2', '43', 'Tunis', 44558, 26872243);
INSERT INTO commande.client (NumCleint, Nom, Rue, Ville, CP, Tel) VALUES (4, 'Moez', '444785', 'Tunis', 778, 87855478);
INSERT INTO commande.client (NumCleint, Nom, Rue, Ville, CP, Tel) VALUES (5, 'fff', '4353', 'djfj', 53543, 45354353);
INSERT INTO commande.client (NumCleint, Nom, Rue, Ville, CP, Tel) VALUES (6, 'fff', '4353', 'djfj', 53543, 45354353);
INSERT INTO commande.client (NumCleint, Nom, Rue, Ville, CP, Tel) VALUES (7, 'fff', '7444', 'lll', 111, 4444);
INSERT INTO commande.client (NumCleint, Nom, Rue, Ville, CP, Tel) VALUES (8, 'g', '474', 'd', 77, 1234);
INSERT INTO commande.client (NumCleint, Nom, Rue, Ville, CP, Tel) VALUES (9, 'dd', 'dd', 'dd', 745, 12346);
INSERT INTO commande.client (NumCleint, Nom, Rue, Ville, CP, Tel) VALUES (10, 'ff', 'gg', 'gg', 11, 111);
INSERT INTO commande.client (NumCleint, Nom, Rue, Ville, CP, Tel) VALUES (11, 'ff', 'ff', '', 444, 777);
INSERT INTO commande.client (NumCleint, Nom, Rue, Ville, CP, Tel) VALUES (12, 'gg', 'gg', 'gg', 11, 11);
INSERT INTO commande.client (NumCleint, Nom, Rue, Ville, CP, Tel) VALUES (13, 'd', 'd', 'd', 1, 44);
INSERT INTO commande.client (NumCleint, Nom, Rue, Ville, CP, Tel) VALUES (14, 'q', 'q', 'q', 1, 1);
INSERT INTO commande.client (NumCleint, Nom, Rue, Ville, CP, Tel) VALUES (15, 'x', 'x', 'x', 1, 1);
INSERT INTO commande.client (NumCleint, Nom, Rue, Ville, CP, Tel) VALUES (16, 'c', 'c', 'c', 2, 2);
INSERT INTO commande.client (NumCleint, Nom, Rue, Ville, CP, Tel) VALUES (17, 'x', 'x', 'x', 4, 4);
INSERT INTO commande.client (NumCleint, Nom, Rue, Ville, CP, Tel) VALUES (18, 'xx', 'xq', 'q', 12, 12);
INSERT INTO commande.client (NumCleint, Nom, Rue, Ville, CP, Tel) VALUES (19, 'q', 'q', 'q', 1, 1);
INSERT INTO commande.client (NumCleint, Nom, Rue, Ville, CP, Tel) VALUES (20, 'c', 'c', 'c', 1, 1);
INSERT INTO commande.client (NumCleint, Nom, Rue, Ville, CP, Tel) VALUES (21, 'tt', 'gg', 'gg', 222, 12);
INSERT INTO commande.client (NumCleint, Nom, Rue, Ville, CP, Tel) VALUES (22, 't', 't', 't', 1, 1);
INSERT INTO commande.client (NumCleint, Nom, Rue, Ville, CP, Tel) VALUES (23, 't', 't', 't', 1, 1);
INSERT INTO commande.client (NumCleint, Nom, Rue, Ville, CP, Tel) VALUES (24, 'ff', 'a', 'll', 4, 1);
INSERT INTO commande.client (NumCleint, Nom, Rue, Ville, CP, Tel) VALUES (25, 'r', 'z', 'z', 4, 1);
INSERT INTO commande.client (NumCleint, Nom, Rue, Ville, CP, Tel) VALUES (26, 's', 'p', 'j', 7, 4);
INSERT INTO commande.client (NumCleint, Nom, Rue, Ville, CP, Tel) VALUES (27, 's', '4', '4', 4, 4);