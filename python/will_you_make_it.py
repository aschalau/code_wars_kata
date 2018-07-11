def zero_fuel(distance_to_pump, mpg, fuel_left):
    can_go = mpg * fuel_left

    if can_go >= distance_to_pump:
        return True
    
    return False

def zero_fuel_2(distance_to_pump, mpg, fuel_left):
    if mpg * fuel_left >= distance_to_pump:
        return True

    return False


def zero_fuel_3(distance_to_pump, mpg, fuel_left):
    return distance_to_pump <= mpg * fuel_left
