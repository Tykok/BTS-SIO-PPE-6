-- Permet de supprimer l'utilisateur concerner par le comptable
CREATE TRIGGER delete_User_Comptable ON comptable
AFTER DELETE
AS

BEGIN
DECLARE @id as int;
SELECT @id = id  FROM deleted --On r�cup�re ici le num�ro du comptable sur le point d'�tre supprim�

DELETE FROM utilisateur WHERE id = @id;
END;