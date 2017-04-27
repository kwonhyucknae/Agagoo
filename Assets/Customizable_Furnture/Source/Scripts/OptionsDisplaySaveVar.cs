using UnityEngine;
using System.Collections;

public class OptionsDisplaySaveVar : MonoBehaviour {
	private string displayAtlasPath="Textures/Atlas_All_TextureDisplay";
	private string displayAtlasPath2="Textures/Atlas_AllPatterns_TextureDisplay";
	private string displayAtlasPath3="Textures/Atlas_AllTransparent_TextureDisplay";
	private string displayAtlasPath4="Textures/Atlas_AllPictures_TextureDisplay";
	private string displayAtlasPath5="Textures/Atlas_AllModelsSwitches_TextureDisplay";
	
	public Texture2D[] LEDTextures;
	public Texture2D[] plasticTextures;
	public Texture2D[] quarryTextures;
	public Texture2D[] woodTextures;
	public Texture2D[] marbleTextures;
	public Texture2D[] clothTextures;
	public Texture2D[] metalTextures;
	public Texture2D[] lampTextures;
	public Texture2D[] rugTextures;
	public Texture2D[] leatherTextures;
	public Texture2D[] graniteTextures;
	
	public Texture2D[] curtainsTextures;
	public Texture2D[] wallsTextures;
	public Texture2D[] floorTextures;
	
	public Texture2D[] blindsTextures;
	public Texture2D[] glassTextures;
	
	public Texture2D[] tallPictures;
	public Texture2D[] longPictures;
	public Texture2D[] quadPictures;
	public Texture2D[] gamePictures;
	
	public Texture2D[] bulbColor;
	public Texture2D[] lightSwitcher;
	public Texture2D[] reverseTexture;
	public Texture2D[] materialType;
	public Texture2D[] floorTile;
	public Texture2D[] modType;
	
	public Texture2D[] wallModels;
	public Texture2D[] doorHandlesModels;
	public Texture2D[] tableLampModels;
	public Texture2D[] floorLampModels;
	public Texture2D[] wallLampModels;
	public Texture2D[] simpleRoofLampModels;
	public Texture2D[] screenModels;
	public Texture2D[] type1ScreenModels;
	public Texture2D[] type2ScreenModels;
	public Texture2D[] lampTableModels;
	public Texture2D[] smallTableModels;
	// Use this for initialization
	void OnEnable () {
		#if UNITY_EDITOR
		#endif
	}
	public void CreateDisplayTextures(){
		
		//new
		LEDTextures=LoadSpritesAsTextures(displayAtlasPath,"LED");            //이 하나하나는 전부 배열 값으로 그 값이 가질 수 있는  경우의 수를 전부 가지고 있다. LEDTextures면 LEDtexuters
		plasticTextures=LoadSpritesAsTextures(displayAtlasPath,"Plastic");    //가 가지는 모든 경우의 수를 가지는 배열. 빨,주,노,초,파 등등 으로
		quarryTextures=LoadSpritesAsTextures(displayAtlasPath,"Quarry");
		woodTextures=LoadSpritesAsTextures(displayAtlasPath,"Wood");
		marbleTextures=LoadSpritesAsTextures(displayAtlasPath,"Marble");
		clothTextures=LoadSpritesAsTextures(displayAtlasPath,"Cloth");
		metalTextures=LoadSpritesAsTextures(displayAtlasPath,"Metal");
		lampTextures=LoadSpritesAsTextures(displayAtlasPath,"LampScreen");
		rugTextures=LoadSpritesAsTextures(displayAtlasPath,"Rug");
		leatherTextures=LoadSpritesAsTextures(displayAtlasPath,"Leather");
		graniteTextures=LoadSpritesAsTextures(displayAtlasPath,"Granite");
		
		curtainsTextures=LoadSpritesAsTextures(displayAtlasPath2,"Curtain");
		wallsTextures=LoadSpritesAsTextures(displayAtlasPath2,"Wall");
		floorTextures=LoadSpritesAsTextures(displayAtlasPath2,"Floor");
		
		blindsTextures=LoadSpritesAsTextures(displayAtlasPath3,"Blinds");
		glassTextures=LoadSpritesAsTextures(displayAtlasPath3,"Glass");
		
		tallPictures=LoadSpritesAsTextures(displayAtlasPath4,"Tall");
		longPictures=LoadSpritesAsTextures(displayAtlasPath4,"Long");
		quadPictures=LoadSpritesAsTextures(displayAtlasPath4,"Quad");
		gamePictures=LoadSpritesAsTextures(displayAtlasPath4,"Game");
		
		bulbColor=LoadSpritesAsTextures(displayAtlasPath5,"BulbColor");
		lightSwitcher=LoadSpritesAsTextures(displayAtlasPath5,"TurnLight");
		reverseTexture=LoadSpritesAsTextures(displayAtlasPath5,"ReverseTexture");
		materialType=LoadSpritesAsTextures(displayAtlasPath5,"MaterialType");
		floorTile=LoadSpritesAsTextures(displayAtlasPath5,"FloorTile");
		modType=LoadSpritesAsTextures(displayAtlasPath5,"ModType");
		
		wallModels=LoadSpritesAsTextures(displayAtlasPath5,"WallWall");
		doorHandlesModels=LoadSpritesAsTextures(displayAtlasPath5,"DoorHandle");
		tableLampModels=LoadSpritesAsTextures(displayAtlasPath5,"TableLamp");
		floorLampModels=LoadSpritesAsTextures(displayAtlasPath5,"FloorLamp");
		wallLampModels=LoadSpritesAsTextures(displayAtlasPath5,"WallLamp");
		simpleRoofLampModels=LoadSpritesAsTextures(displayAtlasPath5,"SimpleRoofLamp");
		screenModels=LoadSpritesAsTextures(displayAtlasPath5,"LampScreen");
		type1ScreenModels=LoadSpritesAsTextures(displayAtlasPath5,"LampScreen1");
		type2ScreenModels=LoadSpritesAsTextures(displayAtlasPath5,"LampScreen2");
		lampTableModels=LoadSpritesAsTextures(displayAtlasPath5,"LampTable");
		smallTableModels=LoadSpritesAsTextures(displayAtlasPath5,"SmallTable");
		
	}
	public Texture2D[] LoadSpritesAsTextures(string path,string spriteIdentifier){
		Texture2D[] targetTextures;
		int tarSpriteCounter=0;
		int textureCounter = 0;
		if (path != "" && path!=null) {
			Sprite[] targetSprites = Resources.LoadAll<Sprite> (path);
			//new code
			//targetSprites=EditorGUIUtility.Load(path) as Sprite;
			//EditorGUIUtility.Objec
			//
			for (int i=0; i<targetSprites.Length;i++){
				if (targetSprites[i].name.Contains(spriteIdentifier)){         //Atlas 그림 저장된 폴더에 가서 해당 모델이 변경 할 수 있는 모든
					tarSpriteCounter++;                                        //모델의 갯수를 tarSpriteCounter 에 저장
				}
			}
			targetTextures = new Texture2D[tarSpriteCounter];                 //targetTextures에 그 모델이 변경 할 수있는 경우의 수 만큼의 배열을 생성
			
			for (int i=0; i< targetSprites.Length; i++) {
				if (targetSprites[i].name.Contains(spriteIdentifier)){          //targetTextures 에 0~ 경우의 수 만큼 해당 변경 할 수 있는 모델에 픽셀 값을 저장
					targetTextures [textureCounter] = new Texture2D ((int)targetSprites [i].rect.width, (int)targetSprites [i].rect.height);
					Color[] pixels = targetSprites [i].texture.GetPixels ((int)targetSprites [i].textureRect.x,
					                                                      (int)targetSprites [i].textureRect.y,
					                                                      (int)targetSprites [i].textureRect.width,
					                                                      (int)targetSprites [i].textureRect.height);
					targetTextures [textureCounter].SetPixels (pixels);
					targetTextures [textureCounter].Apply ();
					textureCounter++;
				}
			}
			return targetTextures;                                         //여기서 return 을 해주므로 CreateDisplayTextures 함수에서 모델들이 각각의 경우의수들을 전부 포함
		} else
			return null;
	}
}
