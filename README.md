# UnrealHaptics Example 

Example project in Unreal Engine 5.3.2

## How to use

- Clone this repository
```
git clone --recursive THIS_REPO_LINK
```
Or
```
git clone THIS_REPO_LINK
git submodule update --init --recursive
```
- Let Unreal Engine generate the solution, build and start as normal
- Updating submodules to latest state (instead of `git pull` in each submodule):
```
git submodule update --remote
```

## Setup own project
Create a `Plugins` folder in your project, then add the plugin as a submodule or create a subfolder and manually copy this content.

### With git submodule
External users need to adapt the URL from `git@` to `https://`. In project root directory (.uproject) run:
```
git submodule add git@gitlab.informatik.uni-bremen.de:cgvr_public/collette.git Plugins/Collette
git submodule add git@gitlab.informatik.uni-bremen.de:cgvr_public/haptico.git Plugins/Haptico
git submodule add git@gitlab.informatik.uni-bremen.de:cgvr_public/forcecomp.git Plugins/ForceComp
```
