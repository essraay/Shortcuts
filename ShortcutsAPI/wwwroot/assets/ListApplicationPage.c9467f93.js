import{z as d,h as m,n as u,o as y,p as g,A as b}from"./index.es.e11e8e1c.js";import{f as h,r as o,j as a,L as k,g as f,F as _}from"./index.25d6ac81.js";import{L as v}from"./LoadingSpinner.1ff07743.js";import{a as C}from"./categories.f304a909.js";import"./request.281ad7e0.js";const w=()=>{const{id:l}=h(),[n,r]=o.exports.useState(!0),[p,t]=o.exports.useState(),c=[{key:"id",label:"#",_props:{scope:"col"}},{key:"tc",label:"TC",_props:{scope:"col"}},{key:"name",label:"Ad\u0131",_props:{scope:"col"}},{key:"surname",label:"Soyad\u0131",_props:{scope:"col"}},{key:"ageRange",label:"Ya\u015F Aral\u0131\u011F\u0131",_props:{scope:"col"}},{key:"category",label:"Ba\u015Fvurulan Meslek",_props:{scope:"col"}},{key:"germanLevel",label:"Almanca Dil Seviyesi",_props:{scope:"col"}},{key:"nationality",label:"Uyruk",_props:{scope:"col"}},{key:"provinces",label:"\u0130l",_props:{scope:"col"}},{key:"phone",label:"Telefon Numaras\u0131",_props:{scope:"col"}},{key:"buttons",label:"",_props:{scope:"col"}}];return o.exports.useEffect(()=>{C(l).then(s=>{const i=s.data.applicationForms.map(e=>({id:e.id,tc:`${e.tc} `,name:`${e.name} `,surname:`${e.surname} `,ageRange:`${e.ageRange.range} `,category:`${s.data.categoryName} `,germanLevel:`${e.germanLevel.level} `,nationality:`${e.nationality.name} `,provinces:`${e.provinces.name} `,phone:`${e.phone} `,buttons:a(d,{children:a("div",{className:"d-flex gap-2",children:a(k,{to:f("applications.detail",{id:e.id}),className:"btn btn-primary btn-sm",children:"Detay"})})}),_cellProps:{id:{scope:"row"},keyCode:{style:{width:"100%"}}}}));t(i)}).finally(()=>r(!1))},[]),a(_,{children:a(m,{children:a(u,{children:a(y,{className:"mx-auto my-3 col-xl-12 shadow",children:a(g,{children:n?a(v,{}):a(b,{className:"text-center",columns:c,items:p,responsive:!0})})})})})})};export{w as default};