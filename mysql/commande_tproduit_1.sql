create table tproduit
(
    CodeTProduit varchar(50) not null
        primary key,
    Designation  varchar(50) not null
)
    engine = InnoDB;

INSERT INTO commande.tproduit (CodeTProduit, Designation) VALUES ('E887', 'Ecouteur');
INSERT INTO commande.tproduit (CodeTProduit, Designation) VALUES ('F47', 'Impri');
INSERT INTO commande.tproduit (CodeTProduit, Designation) VALUES ('P44', 'PC');
INSERT INTO commande.tproduit (CodeTProduit, Designation) VALUES ('S787', 'Souris');