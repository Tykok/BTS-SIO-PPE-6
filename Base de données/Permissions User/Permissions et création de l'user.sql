-- Ses commandes sont a effectu� sur un compte admin ayant les droits pour les faires!!!!


-- Cr�ation du login de connexion avec un mot de passe
CREATE LOGIN AdminGSB
WITH PASSWORD = '12-Soleil&';

-- Cr�ation d'un utilisateur
CREATE USER AdminGSB FOR LOGIN AdminGSB;


-- Permissions sur les principal requ�tes du CRUD sur les donn�es de la BDD
GRANT SELECT, UPDATE, DELETE, INSERT
  TO AdminGSB;


  -- Permissions sur les diff�rentes proc�dures stock�es (que le droit � l'�x�cution)
  GRANT EXECUTE ON OBJECT::Insert_Update_User
  TO AdminGSB;


  GRANT EXECUTE ON OBJECT::rendre_Vehicule_Dispo
  TO AdminGSB;

  GRANT EXECUTE ON OBJECT::verifAdd_VoitureForVisiteur
  TO AdminGSB;


-- Source pour apprendre le grantt --> http://www.bts-sio.com/cours/SI3/sql/8%20-%20GRANT.php
-- OU --> https://www.techonthenet.com/sql_server/grant_revoke.php