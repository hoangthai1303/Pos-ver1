$(function(){'use strict';$(".wrap-preloader").fadeOut();$('.link-back').on('click',function(){window.history.back();return false;});$(".carousel-slide").owlCarousel({items:1,navigation:true,slideSpeed:1000,dots:true,paginationSpeed:400,singleItem:true,loop:true});$(".product-d-slide").owlCarousel({items:1,slideSpeed:1000,dots:true,paginationSpeed:400,loop:false,margin:10});$('.walkthrough-slider').owlCarousel({items:true,loop:false,marign:10});$(".slide-show").owlCarousel({items:1,navigation:true,slideSpeed:1000,dots:true,paginationSpeed:400,singleItem:true,loop:true,autoplay:true});$('.menu-link').bigSlide({menu:'#menu',side:'left',easyClose:true,menuWidth:'260px',afterOpen:function(){$('body').addClass('menu-open');},afterClose:function(){$('body').removeClass('menu-open');}});$('.menu-link-2').bigSlide({menu:'#menu2',side:'right',easyClose:true,menuWidth:'260px',afterOpen:function(){$('body').addClass('menu-open');},afterClose:function(){$('body').removeClass('menu-open');}});$(".slide-show-home").owlCarousel({items:1,navigation:true,slideSpeed:1000,dots:true,paginationSpeed:400,singleItem:true,loop:true});$(".testimonial-slide").owlCarousel({items:1,navigation:true,slideSpeed:1000,dots:true,paginationSpeed:400,singleItem:true,autoplay:true,loop:true});$(".b-seller-slide").owlCarousel({items:2,slideSpeed:1000,dots:true,paginationSpeed:400,loop:false,margin:10});$(".wt-slide").owlCarousel({items:1,navigation:true,slideSpeed:1000,dots:true,paginationSpeed:400,singleItem:true,loop:false});$('.wrap-chat-l .content-text').on('click',function(){window.location='chat-detail.html'});});