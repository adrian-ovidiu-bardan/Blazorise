import{s as a,e as o,l as n,E as h}from"./vidstack-Bv1scj9I.js";import"./vidstack-CsZuoh6p.js";class c{#t;#s;#i;#e=a(!1);get supported(){return this.#e()}constructor(e,t){this.#t=e,this.#s=t,this.#r()}#r(){!this.#t?.remote||!this.canPrompt||(this.#t.remote.watchAvailability(e=>{this.#e.set(e)}).catch(()=>{this.#e.set(!1)}),o(this.#a.bind(this)))}#a(){if(!this.#e())return;const e=["connecting","connect","disconnect"],t=this.#o.bind(this);t(),n(this.#t,"playing",t);const s=new h(this.#t.remote);for(const r of e)s.add(r,t)}async prompt(){if(!this.supported)throw Error("Not supported on this platform.");return this.type==="airplay"&&this.#t.webkitShowPlaybackTargetPicker?this.#t.webkitShowPlaybackTargetPicker():this.#t.remote.prompt()}#o(e){const t=this.#t.remote.state;if(t===this.#i)return;const s={type:this.type,state:t};this.#s.notify("remote-playback-change",s,e),this.#i=t}}class p extends c{type="airplay";get canPrompt(){return"WebKitPlaybackTargetAvailabilityEvent"in window}}export{p as H};
