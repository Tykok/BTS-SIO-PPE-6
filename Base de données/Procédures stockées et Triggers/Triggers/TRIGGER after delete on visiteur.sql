-- Permet de supprimer l'utilisateur concerner par le visiteur
CREATE TRIGGER delete_User_Visiteur ON visiteur
AFTER DELETE
AS

BEGIN
DECLARE @id as int;
SELECT @id = id  FROM deleted --On r�cup�re ici le num�ro du visiteur sur le point d'�tre supprim�

DELETE FROM utilisateur WHERE id = @id;
END;