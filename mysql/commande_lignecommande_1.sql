create table lignecommande
(
    CodeProduit varchar(50) not null,
    NumCmd      int(50)     null,
    Qte         int(50)     not null,
    Prix        int(50)     not null,
    constraint `ligne commande_ibfk_2`
        foreign key (NumCmd) references commande (NumCmd)
            on update cascade on delete cascade,
    constraint lignecommande_ibfk_1
        foreign key (CodeProduit) references produit (CodeProduit)
            on update cascade on delete cascade
)
    engine = InnoDB;

create index `Code Produit`
    on lignecommande (CodeProduit);

INSERT INTO commande.lignecommande (CodeProduit, NumCmd, Qte, Prix) VALUES ('1', 1, 50, 100);
INSERT INTO commande.lignecommande (CodeProduit, NumCmd, Qte, Prix) VALUES ('2', 2, 100, 250);
INSERT INTO commande.lignecommande (CodeProduit, NumCmd, Qte, Prix) VALUES ('2', null, 4, 500);