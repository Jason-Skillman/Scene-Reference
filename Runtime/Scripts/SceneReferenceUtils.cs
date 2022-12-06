namespace JasonSkillman.SceneRef
{
	using System;

	public static class SceneReferenceUtils
	{
		/// <summary>Converts a SceneReference array to a string array.</summary>
		public static string[] ToStringArray(this SceneReference[] sceneReferences)
		{
			if(sceneReferences.Length <= 0)
				return Array.Empty<string>();
			
			string[] scenes = new string[sceneReferences.Length];
			for(int i = 0; i < sceneReferences.Length; i++) 
				scenes[i] = sceneReferences[i].SceneName;
			return scenes;
		}
	}
}
