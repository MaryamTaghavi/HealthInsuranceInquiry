# توضيحات فني
- پروژه تحت قالب .Net 8  و معماري CleanArchitecture با چهار لايه اصلي Api / Application / Domain / Infrastructure ايجاد شده است.
- در اين پروژه از Mediator Pattern استفاده شده است.
- براي راحتي كار و تست راحت تر از In-Memory Database استفاده شده است.
- مقادیر پوشش به علت اینکه در صورت سوال ذکر شده از قبل تعیین شده در enum ذخیره شده و تحت یک api لیست آنها بر میگردد.
- یک middleware اختصاصی برای مدیریت exception ها طراحی شده است.
- کلاس ValidationBehaviorPipeline برای مدیریت validator ها از پترن mediator و همچنین خطاهای احتمالی در سایر کلاس ها ایجاد شده است.
