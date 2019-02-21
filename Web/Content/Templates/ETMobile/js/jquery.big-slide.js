/*! bigSlide - v0.9.3 - 2015-11-04
* http://ascott1.github.io/bigSlide.js/
* Copyright (c) 2015 Adam D. Scott; Licensed MIT */!function(a){"use strict";"function"==typeof define&&define.amd?define(["jquery"],a):"object"==typeof exports?module.exports=a(require("jquery")):a(jQuery)}(function(a){"use strict";function b(a,b){for(var c,d=a.split(";"),e=b.split(" "),f="",g=0,h=d.length;h>g;g++){c=!0;for(var i=0,j=e.length;j>i;i++)(""===d[g]||-1!==d[g].indexOf(e[i]))&&(c=!1);c&&(f+=d[g]+"; ")}return f}a.fn.bigSlide=function(c){var d=this,e=a.extend({menu:"#menu",push:".push",side:"left",menuWidth:"15.625em",speed:"300",state:"closed",activeBtn:"active",easyClose:!1,beforeOpen:function(){},afterOpen:function(){},beforeClose:function(){},afterClose:function(){}},c),f="transition -o-transition -ms-transition -moz-transitions webkit-transition "+e.side,g={menuCSSDictionary:f+" position top bottom height width",pushCSSDictionary:f,state:e.state},h={init:function(){i.init()},_destroy:function(){return i._destroy(),delete d.bigSlideAPI,d},changeState:function(){g.state="closed"===g.state?"open":"closed"},getState:function(){return g.state}},i={init:function(){this.$menu=a(e.menu),this.$push=a(e.push),this.width=e.menuWidth;var b={position:"fixed",top:"0",bottom:"0",height:"100%"};b[e.side]="-"+e.menuWidth,b.width=e.menuWidth,"closed"===e.state&&(this.$menu.css(b),this.$push.css(e.side,"0"));var c={"-webkit-transition":e.side+" "+e.speed+"ms ease","-moz-transition":e.side+" "+e.speed+"ms ease","-ms-transition":e.side+" "+e.speed+"ms ease","-o-transition":e.side+" "+e.speed+"ms ease",transition:e.side+" "+e.speed+"ms ease"};this.$menu.css(c),this.$push.css(c),d.on("click.bigSlide touchstart.bigSlide",function(a){a.preventDefault(),"open"===h.getState()?i.toggleClose():i.toggleOpen()}),e.easyClose&&a(document).on("click.bigSlide",function(b){a(b.target).parents().andSelf().is(d)||a(b.target).closest(e.menu).length||"open"!==h.getState()||i.toggleClose()})},_destroy:function(){this.$menu.each(function(){var c=a(this);c.attr("style",b(c.attr("style"),g.menuCSSDictionary).trim())}),this.$push.each(function(){var c=a(this);c.attr("style",b(c.attr("style"),g.pushCSSDictionary).trim())}),d.removeClass(e.activeBtn).off("click.bigSlide touchstart.bigSlide"),this.$menu=null,this.$push=null},toggleOpen:function(){e.beforeOpen(),h.changeState(),this.$menu.css(e.side,"0"),this.$push.css(e.side,this.width),d.addClass(e.activeBtn),e.afterOpen()},toggleClose:function(){e.beforeClose(),h.changeState(),this.$menu.css(e.side,"-"+this.width),this.$push.css(e.side,"0"),d.removeClass(e.activeBtn),e.afterClose()}};return h.init(),this.bigSlideAPI={settings:e,model:g,controller:h,view:i,destroy:h._destroy},this}});