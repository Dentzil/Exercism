#import "HelloWorld.h"

@implementation HelloWorld

-(NSString *)hello: (NSString *)input {
    return [NSString stringWithFormat: @"Hello, %@!", input ?: @"World"];
}

@end
