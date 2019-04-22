import { Component, OnInit, Input } from '@angular/core';
import { initDomAdapter } from '@angular/platform-browser/src/browser';
import { bloomAdd } from '@angular/core/src/render3/di';

@Component({
  selector: 'app-skill',
  templateUrl: './skill.component.html',
  styleUrls: ['./skill.component.less']
})
export class SkillComponent implements OnInit {

  @Input() name: string;
  @Input() imagePath: string;
  @Input() level: number;

  levelList: boolean[] = [false, false, false, false, false];

  constructor() { }

  ngOnInit() {
    if (this.level > 5 || this.level < 0) throw new Error("Level cannot must be betweeen 0 and 5");
    for (let index = 0; index < this.level; index++) {
      this.levelList[index] = true;
    }
  }

}
