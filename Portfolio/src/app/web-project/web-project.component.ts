import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-web-project',
  template: `
  <div class="container">
    <h1 class="text-light text-center">{{name}}</h1>
    <p class="text-light text-center">{{time}}</p>
    <p class="text-light text-center">{{description}}</p>
    <div *ngFor="let tech of technologiesList">
      <div class="text-light row justify-content-center">
        <app-skill name="{{tech}}"></app-skill>
      </div>
    </div>
    <br>
  </div>`,
  styleUrls: ['./web-project.component.less']
})
export class WebProjectComponent implements OnInit {

  @Input() name:string;
  @Input() description:string;
  @Input() time:string;
  @Input() technologies:string;

  technologiesList:string[];
  private hasBootstrap = () => this.technologiesList.includes("Bootstrap");

  constructor() { }

  ngOnInit() {
    this.technologiesList = this.technologies.split(",").map(data => data.trim());
  }

}
