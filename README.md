Unity steps :
- Before : créer les png pile à la bonne taille pour les boxcolliders. 
	créer les dossiers. avoir les scripts prêts
- mettre l'image du ninja direct sur la scène, un gameObject est crée. 
	Add un rigidbody 2D pour lui appliquer la physique de Unity. 
- Tester et se rendre compte que le ninja tombe
- ajouter un ground. Tester et le ninja passe à travers. 
	Ajouter et un boxCollider2D (les edit) sur le ninja et le ground. Tada ! le ninja tient sur ses pieds.
- Ninja : rigidBody : Constraint freeze rotation
- Créer un script sur le Ninja (1), set la moveSpeed à 5 et Tester
- Créer un prefabs de la plateforme.
- Ajoutez une platforme, le ninja tombe ! 
- Coder le jump (2) set la jumpForce à  10 Tester. Ca fonctionne mais on dirait un astronaute sur la lune. 
	Augmenter la gravité du ninja à 4 et la jumpForce à 15.
- Problème des jumps à l'infini.
- Layer Ground pour l'identifier.