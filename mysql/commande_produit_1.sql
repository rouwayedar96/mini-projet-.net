create table produit
(
    CodeProduit  varchar(50) not null
        primary key,
    Designation  varchar(50) not null,
    CodeTProduit varchar(50) not null,
    constraint produit_ibfk_1
        foreign key (CodeTProduit) references tproduit (CodeTProduit)
            on update cascade on delete cascade
)
    engine = InnoDB;

create index CodeTProduit
    on produit (CodeTProduit);

INSERT INTO commande.produit (CodeProduit, Designation, CodeTProduit) VALUES ('1', 'PC acer', 'F47');
INSERT INTO commande.produit (CodeProduit, Designation, CodeTProduit) VALUES ('2', 'Souris sans fil', 'S787');
INSERT INTO commande.produit (CodeProduit, Designation, CodeTProduit) VALUES ('DE44', 'Livre', 'S787');