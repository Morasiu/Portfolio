import { Injectable } from '@angular/core';

@Injectable()
export class ImageService {
    readonly rootPath = "./assets/images/thumbnails/"; 
    private pathDictionary: {[key: string]: string;} = {
        "C#": this.rootPath + "dot_net_small.png",
        "Python": this.rootPath + "python_small.png",
        "Java": this.rootPath + "java_small.png",
        "ASP.Net Core": this.rootPath + "asp_small.png",
        "Visual Studio": this.rootPath + "vs.png",
        "Unity": this.rootPath + "unity.png",
        "Git": this.rootPath + "git_small.png",
        "Linux": this.rootPath + "tux_small.png",
        "Android Studio": this.rootPath + "android_small.png",
        "VR - Oculus": this.rootPath + "oculus_light_small.png",
        "SQL": this.rootPath + "db_small.png",
        "Blender": this.rootPath + "blender_small.png",
        "Angular": this.rootPath + "angular.png",
        "Bootstrap": this.rootPath + "bootstrap-solid.svg",
        "English": this.rootPath + "english_small.png",
        "Rest API": this.rootPath + "rest_small.png",
        "Unit tests": "https://img.icons8.com/flat_round/64/000000/checkmark.png",
        "xUnit": this.rootPath + "x_unit.png",
        "Design patterns": this.rootPath + "design_small.png",
    };

    getImagePathFor(skill: string):string {
        return this.pathDictionary[skill];
    }
}