import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-web-project',
  templateUrl: './web-project.component.html',
  styleUrls: ['./web-project.component.less']
})
export class WebProjectComponent implements OnInit {

  @Input() name:string;
  @Input() description:string;

  constructor() { }

  ngOnInit() {
  }

}
