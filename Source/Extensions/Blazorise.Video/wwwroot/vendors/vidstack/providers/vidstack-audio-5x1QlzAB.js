import{k as t}from"../chunks/vidstack-Bv1scj9I.js";import{HTMLMediaProvider as e}from"./vidstack-html-CtgDGWSp.js";import{H as o}from"../chunks/vidstack-RA6QZR4u.js";import"../chunks/vidstack-CsZuoh6p.js";import"../chunks/vidstack-DfgcZT7D.js";import"../chunks/vidstack-Bxv1Qnxe.js";import"../chunks/vidstack-C_AxqLKV.js";class s extends e{$$PROVIDER_TYPE="AUDIO";get type(){return"audio"}airPlay;constructor(r,i){super(r,i),t(()=>{this.airPlay=new o(this.media,i)},this.scope)}setup(){super.setup(),this.type==="audio"&&this.ctx.notify("provider-setup",this)}get audio(){return this.media}}export{s as AudioProvider};
