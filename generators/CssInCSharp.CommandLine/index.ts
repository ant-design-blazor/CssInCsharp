const genMotionStyle: GenerateStyle<DrawerToken> = (token) => {
    return {
        [componentCls]: {
            [`&-${direction}`]: "str".sub(() => ({})),
        },
    };
};