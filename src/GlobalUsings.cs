global using ECSGameEngine;
global using Raylib_cs;

// Put this here because I guess it should go in a "global usings" file.
// Couldn't put it right above EngineContext class because the class wasn't defined yet
// and I didn't want to just put it under it
// and I also didn't want to put it in a random file.
global using Ctx = ECSGameEngine.EngineContext;