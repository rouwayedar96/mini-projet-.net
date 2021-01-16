create table commande
(
    NumCmd       int(50) auto_increment
        primary key,
    DateCommande date    null,
    NumClient    int(50) null,
    constraint commande_ibfk_1
        foreign key (NumClient) references client (NumCleint)
            on update cascade on delete cascade
)
    engine = InnoDB;

create index NumClient
    on commande (NumClient);

INSERT INTO commande.commande (NumCmd, DateCommande, NumClient) VALUES (1, '2021-01-12', 3);
INSERT INTO commande.commande (NumCmd, DateCommande, NumClient) VALUES (2, '2021-01-07', 2);
INSERT INTO commande.commande (NumCmd, DateCommande, NumClient) VALUES (3, null, null);
INSERT INTO commande.commande (NumCmd, DateCommande, NumClient) VALUES (6, null, 1);
INSERT INTO commande.commande (NumCmd, DateCommande, NumClient) VALUES (7, null, null);
INSERT INTO commande.commande (NumCmd, DateCommande, NumClient) VALUES (8, null, null);
INSERT INTO commande.commande (NumCmd, DateCommande, NumClient) VALUES (9, null, null);
INSERT INTO commande.commande (NumCmd, DateCommande, NumClient) VALUES (10, null, null);
INSERT INTO commande.commande (NumCmd, DateCommande, NumClient) VALUES (11, null, null);
INSERT INTO commande.commande (NumCmd, DateCommande, NumClient) VALUES (12, null, null);
INSERT INTO commande.commande (NumCmd, DateCommande, NumClient) VALUES (13, '2021-01-19', 16);