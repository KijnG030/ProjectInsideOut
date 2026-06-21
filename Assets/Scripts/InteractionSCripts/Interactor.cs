//using Unity.VisualScripting;
//using UnityEngine;


//public class Interactor : MonoBehaviour
//{
//    [SerializeField] private Transform InteractorSource;
//	[SerializeField] private float InteractorRange = 1.0f;
//	[SerializeField] private LayerMask InteractableLayerMask;
//	[SerializeField] private UI PaperUI;

//	private readonly Collider[] ICollider = new Collider[10];
//	[SerializeField] private int IColliderFound;

//	private IInteractable interactable;


//	private void Update()
//	{
//		IColliderFound = Physics.OverlapSphereNonAlloc(InteractorSource.position, InteractorRange, ICollider, InteractableLayerMask);

//		if (IColliderFound > 0)
//		{
//			interactable = ICollider[0].GetComponent<IInteractable>();

//			if (interactable != null)
//			{
//				if (Input.GetKeyDown(KeyCode.E))
//				{
//					if (!PaperUI.IsDisplayed)
//					{
//						PaperUI.SetUp(interactable.InteractionMessage);
//					}
//					interactable.Interact();
//				}

//				if (PaperUI.IsDisplayed && Input.GetKeyDown(KeyCode.Escape))
//				{
//					PaperUI.Close();
//				}
//			}
//		}
//		else
//		{
//			if (interactable != null) interactable = null;
//			if (PaperUI.IsDisplayed) PaperUI.Close();
//		}

//	}

	
//}
