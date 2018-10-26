findRangeOverlap = (point1, length1, point2, length2) => {
  const highestStartPoint = Math.max(point1, point2);
  const lowestEndPoint = Math.min(point1 + length1, point2 + length2);

  if (highestStartPoint >= lowestEndPoint) {
    return { startPoint: null, overlapLength: null };
  }

  const overlapLength = lowestEndPoint - highestStartPoint;

  return { startPoint: highestStartPoint, overlapLength: overlapLength };
};

findRectangularOverlap = (rect1, rect2) => {
  const xOverlap = findRangeOverlap(
    rect1.leftX,
    rect1.width,
    rect2.leftX,
    rect2.width
  );
  const yOverlap = findRangeOverlap(
    rect1.bottomY,
    rect1.height,
    rect2.bottomY,
    rect2.height
  );

  if (!xOverlap.overlapLength || !yOverlap.overlapLength) {
    return {
      leftX: 0,
      bottomY: 0,
      width: 0,
      height: 0
    };
  }

  return {
    leftX: xOverlap.startPoint,
    bottomY: yOverlap.startPoint,
    width: xOverlap.overlapLength,
    height: yOverlap.overlapLength
  };
};
