Unity steps :
- Before : cr�er les png pile � la bonne taille pour les boxcolliders. 
	cr�er les dossiers. avoir les scripts pr�ts
- mettre l'image du ninja direct sur la sc�ne, un gameObject est cr�e. 
	Add un rigidbody 2D pour lui appliquer la physique de Unity. 
- Tester et se rendre compte que le ninja tombe
- ajouter un ground. Tester et le ninja passe � travers. 
	Ajouter et un boxCollider2D (les edit) sur le ninja et le ground. Tada ! le ninja tient sur ses pieds.
- Ninja : rigidBody : Constraint freeze rotation
- Cr�er un script sur le Ninja (1), set la moveSpeed � 5 et Tester
- Cr�er un prefabs de la plateforme.
- Ajoutez une platforme, le ninja tombe ! 
- Coder le jump (2) set la jumpForce �  10 Tester. Ca fonctionne mais on dirait un astronaute sur la lune. 
	Augmenter la gravit� du ninja � 4 et la jumpForce � 15.
- Probl�me des jumps � l'infini.
- Layer Ground pour l'identifier.