import { Component, OnInit, Input } from '@angular/core';
import { DomSanitizer, SafeResourceUrl } from '@angular/platform-browser';

@Component({
  selector: 'app-game-video',
  templateUrl: './game-video.component.html',
  styleUrls: ['./game-video.component.less']
})
export class GameVideoComponent implements OnInit{
  ngOnInit(): void {
    this.safeLink = this._sanitizer.bypassSecurityTrustResourceUrl(this.link);
  }
  @Input() name:string;
  @Input() description:string;
  @Input() link:string;
  safeLink:SafeResourceUrl;

  constructor(private _sanitizer: DomSanitizer){
 }
}
