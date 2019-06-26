import { Component, OnInit, Input } from '@angular/core';
import { ImageService } from '../services/ImageService';

@Component({
  selector: 'app-skill',
  templateUrl: './skill.component.html',
  styleUrls: ['./skill.component.less']
})
export class SkillComponent implements OnInit {

  @Input() name: string;
  @Input() imagePath: string;
  @Input() level: number;

  public skillImagePath: string = "Default path";
  levelList: boolean[] = [false, false, false, false, false];

  constructor(private imageService: ImageService) {}

  ngOnInit() {
    if (this.level > 5 || this.level < 0) throw new Error("Level cannot must be between 0 and 5");
    for (let index = 0; index < this.level; index++) {
      this.levelList[index] = true;
    }
    if(this.imagePath === undefined)
      this.skillImagePath = this.imageService.getImagePathFor(this.name);
  }
}
