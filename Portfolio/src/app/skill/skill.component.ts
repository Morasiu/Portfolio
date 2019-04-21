import { Component, OnInit, Input } from '@angular/core';
import { initDomAdapter } from '@angular/platform-browser/src/browser';

@Component({
  selector: 'app-skill',
  templateUrl: './skill.component.html',
  styleUrls: ['./skill.component.less']
})
export class SkillComponent implements OnInit {

  @Input() name: string;
  @Input() imagePath: string;
  constructor() { }

  ngOnInit() {
  }

}
