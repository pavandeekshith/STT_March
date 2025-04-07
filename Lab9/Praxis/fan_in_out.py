import json
import sys
import csv

def calculate_fan_in_out(json_file, output_csv):
    with open(json_file, "r") as file:
        data = json.load(file)

    fan_in = {}
    fan_out = {}

    for module in data.keys():
        fan_in[module] = 0 
        fan_out[module] = len(data[module])

    for module, dependencies in data.items():
        for dep in dependencies:
            fan_in[dep] = fan_in.get(dep, 0) + 1

    with open(output_csv, "w", newline="") as csvfile:
        writer = csv.writer(csvfile)
        writer.writerow(["Module", "Fan-in", "Fan-out"]) 

        for module in sorted(fan_in.keys()):
            writer.writerow([module, fan_in[module], fan_out.get(module, 0)])

    print(f"Results saved to {output_csv}")

if __name__ == "__main__":
    if len(sys.argv) != 3:
        print("Usage: python fan_in_out.py <dependencies.json> <output.csv>")
        sys.exit(1)

    json_file = sys.argv[1]
    output_csv = sys.argv[2]
    calculate_fan_in_out(json_file, output_csv)

