// <reference path="helpers/WebMap.all.d.ts"/>
/// <reference path="helpers/require.d.ts"/>
define("$rootnamespace$.$basename$", ["text!views/$rootnamespace$.$basename$.html","css!views/$rootnamespace$.$basename$.css"],
    (htmlTemplate) => {
        class $basename$ extends WebMap.Client.BaseLogic {

            static options = {
                template: WebMap.Client.ViewManager.CompileView("$rootnamespace$.$basename$", htmlTemplate)
            }

            logic: $basename$;
            Init(): void {
                super.BuildUI($basename$.options.template);
            }


            public button1_Click(e: any) {
                return window.app.sendAction({ mainobj: this, controller: "$basename$", action: "button1_Click" });
                e.preventDefault();
            }


        }
        return $basename$;
    });

